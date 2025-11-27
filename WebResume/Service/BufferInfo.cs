using Contracts;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Contracts;

namespace Service
{
  public class BufferInfo : IBufferInfo
  {
    private readonly ILoggerManager _logger;
    private readonly IPhotoService _photoService;
    private readonly IFileService _fileService;
    private readonly RepositoryContext _context;
    public BufferInfo(ILoggerManager logger, IPhotoService photoService, IFileService fileService, RepositoryContext context)
    {
      _logger = logger;
      _photoService = photoService;
      _fileService = fileService;
      _context = context;
    }

    /// <summary>
    /// Добавить в таблицу Buffer информацию об имени файла, который в будущем будет удален фоновым процессом (background service) 
    /// </summary>
    /// <param name="resumeId">Id резюме</param>
    /// <param name="token">токен отмены</param>
    public async Task AddPhotoInfoToBuffer(Guid resumeId, CancellationToken token)
    {
      var photo = await _photoService.GetPhotoByResumeAsync(resumeId, token);
      if (photo is null)
        return;

      var bufferInfo = new BufferEntity
      {
        Id = Guid.NewGuid(),
        FileName = photo.FileName
      };
      await _context.BufferInfo.AddAsync(bufferInfo);
    }

    private async Task<BufferEntity?> GetBufferInfoAsync(string fileName) => 
      await _context.BufferInfo
      .Where(b => b.FileName.Equals(fileName))
      .FirstOrDefaultAsync();

    public async Task DeletePhotoInfoFromBuffer()
    {
      var photos = await _context.BufferInfo.ToListAsync();
      if (!photos.Any())
        return;

      foreach (var item in photos)
      {
        await _fileService.DeletePhotoFromStorageAsync(item.FileName);

        var bufferEntity = await GetBufferInfoAsync(item.FileName);
        _context.BufferInfo.Remove(bufferEntity);
      }

      await _context.SaveChangesAsync();
    }
  }
}
