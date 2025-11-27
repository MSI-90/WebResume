using Contracts;
using Entites.Models;
using Repository;
using Service.Contracts;

namespace Service
{
  public class BufferInfo : IBufferInfo
  {
    private readonly ILoggerManager _logger;
    private readonly IPhotoService _fileService;
    private readonly RepositoryContext _context;
    public BufferInfo(ILoggerManager logger, IPhotoService service, RepositoryContext context)
    {
      _logger = logger;
      _fileService = service;
      _context = context;
    }

    /// <summary>
    /// Добавить в таблицу Buffer информацию об имени файла, которй в будущем будет удален фоновым процессом (background service) 
    /// </summary>
    /// <param name="resumeId">Id резюме</param>
    /// <param name="token">токен отмены</param>
    public async Task AddPhotoInfoToBuffer(Guid resumeId, CancellationToken token)
    {
      var photo = await _fileService.GetPhotoByResumeAsync(resumeId, token);
      if (photo is null)
        return;

      var bufferInfo = new BufferEntity
      {
        Id = Guid.NewGuid(),
        FileName = photo.FileName
      };
      await _context.BufferInfo.AddAsync(bufferInfo);
    }
  }
}
