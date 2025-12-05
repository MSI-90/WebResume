using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
  public sealed class FileService : IFileService
  {
    private readonly ILoggerManager _loggerManager;
    private readonly string _filePath;
    public FileService(ILoggerManager loggerManager, string filePath)
    {
      _loggerManager = loggerManager;
      _filePath = filePath;
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
        _loggerManager.LogError($"File is not created {ex.Message}");
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
          _loggerManager.LogInfo($"Файл {fileName} удален");
        }
        else
        {
          _loggerManager.LogWarn($"Файл {fileName} не найден");
        }
      }
      catch (Exception ex)
      {
        _loggerManager.LogWarn($"Ошибка при удалении: {ex.Message}");
        throw;
      }
    }
  }
}
