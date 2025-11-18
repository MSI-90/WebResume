using Contracts;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;
using Microsoft.Extensions.Configuration;

namespace Service
{
  public sealed class FileService : IFileService
  {
    private readonly ILoggerManager _loggerManager;
    private readonly RepositoryContext _context;
    private readonly string _filePath;
    public FileService(string filePath, ILoggerManager loggerManager, RepositoryContext context) 
    {
      _filePath = filePath;
      _loggerManager = loggerManager;
      _context = context;
    }

    public async Task<(string, Guid)> ReadStream(FileDto file)
    {
      if (file is null)
        throw new ArgumentNullException(nameof(file));

      try
      {
        var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file?.FileName)}";
        var filePath = Path.Combine(_filePath, fileName);

        using (var stream = new FileStream(filePath, FileMode.Create))
        {
          await file?.FileStream?.CopyToAsync(stream);
        }

        return (fileName ?? string.Empty, Guid.NewGuid());
      } catch (Exception ex)
      {
        _loggerManager.LogError($"File is not created {ex.Message}");
        throw;
      }
    }
  }
}
