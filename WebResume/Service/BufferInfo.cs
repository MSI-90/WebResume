using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository;
using Service.Contracts;

namespace Service
{
  public class BufferInfo : IBufferInfo
  {
    private readonly ILogger _logger;
    private readonly IPhotoService _photoService;
    private readonly IFileService _fileService;
    private readonly RepositoryContext _context;
    public BufferInfo(ILogger<BufferInfo> logger, IPhotoService photoService, IFileService fileService, RepositoryContext context)
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

    /// <summary>
    /// Получить список записей из таблицы Buffer
    /// </summary>
    /// <returns>Коллекция типа List<BufferEntity></returns>
    private async Task<List<BufferEntity>> GetBufferInfosAsync() =>
      await _context.BufferInfo.ToListAsync();

    /// <summary>
    /// При наличии записей в таблице Buffer удалить файлы фото из папки и запись из таблицы.
    /// Каждая запись в таблице содержит имя файла соответсвующее имени файла в папке.
    /// </summary>
    /// <returns>В случае отсутсвия записей в таблице БД просто завершает работу</returns>
    public async Task DeletePhotoInfoFromBuffer()
    {
      var photos = await GetBufferInfosAsync();
      if (photos.Count == 0)
        return;

      foreach (var item in photos)
      {
        if (!string.IsNullOrEmpty(item.FileName))
        {
          await _fileService.DeletePhotoFromStorageAsync(item.FileName);
          _context.BufferInfo.Remove(item);
        }
      }

      await _context.SaveChangesAsync();
    }
  }
}
