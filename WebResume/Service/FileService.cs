using Contracts;
using Microsoft.Extensions.Logging;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
  public sealed class FileService : IFileService
  {
    private readonly ILoggerManager _loggerManager;
    private readonly string _filePath;
    private readonly IPhotoService _photoService;
    public FileService(ILoggerManager loggerManager, string filePath, IPhotoService photoService)
    {
      _loggerManager = loggerManager;
      _filePath = filePath;
      _photoService = photoService;
    }
    public async Task<PhotoToUpload> CreatePhotoFileAsync(FileDto file, Guid resumeId)
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
        var photoId = await _photoService.AddPhotoInfoAsync(file, resumeId);
        return new PhotoToUpload(fileName, photoId, filePath);

      }
      catch (Exception ex)
      {
        _loggerManager.LogError($"File is not created {ex.Message}");
        if (File.Exists(filePath))
          File.Delete(filePath);
        throw;
      }
    }

    public async Task DeletePhotoFromStorageAsync(string fileName)
    {
      try
      {
        string? filePath = Path.Combine(_filePath, fileName);

        if (File.Exists(filePath))
        {
          File.Delete(filePath);
          _loggerManager.LogInfo($"Файл {fileName}");
          Console.WriteLine($"Файл {fileName} удален");
        }
        else
        {
          _loggerManager.LogWarn($"Файл {fileName} не найден");
          Console.WriteLine($"Файл {fileName} не найден");
        }
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Ошибка при удалении: {ex.Message}");
      }
    }
  }
}
