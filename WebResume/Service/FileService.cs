using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
  public sealed class FileService : IFileService
  {
    private readonly IConfiguration _configuration;
    private readonly ILogger _logger;
    private readonly string _filePath;
    public FileService(IConfiguration configuration, ILogger<FileService> logger)
    {
      _configuration = configuration;
      _logger = logger;
      _filePath = _configuration["FileStorage"] ?? string.Empty;
    }
    public async Task<PhotoToUpload> CreatePhotoFileAsync(FileDto file)
    {
      if (file is null || file?.FileStream is null)
        throw new ArgumentNullException(nameof(file));

      Directory.CreateDirectory(_filePath);
      var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file?.FileName ?? "")}";
      var filePath = Path.Combine(_filePath, fileName);

      try
      {
        using var stream = new FileStream(filePath, FileMode.Create);
        await file!.FileStream.CopyToAsync(stream);

        file.FileName = fileName;
        return new PhotoToUpload(fileName, filePath);
      }
      catch (Exception ex)
      {
        _logger.LogError($"File is not created {ex.Message}");
        if (File.Exists(filePath))
          File.Delete(filePath);
        throw;
      }
    }
    public async Task DeletePhotoFromStorageAsync(string fileName)
    {
      string? filePath = Path.Combine(_filePath, fileName);
      try
      {
        if (File.Exists(filePath))
        {
          await Task.Run(() => File.Delete(filePath));
          _logger.LogInformation($"Файл {fileName} удален");
        }
        else
        {
          _logger.LogWarning($"Файл {fileName} не найден");
        }
      }
      catch (Exception ex)
      {
        _logger.LogWarning($"Ошибка при удалении: {ex.Message}");
        throw;
      }
    }
  }
}
