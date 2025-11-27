using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IPhotoService
  {
    Task<Photo?> GetPhotoAsync(Guid photoId, CancellationToken token);
    Task<Photo?> GetPhotoByResumeAsync(Guid resumeId, CancellationToken token);
    Task<Guid?> AddPhotoInfoAsync(FileDto file, Guid resumeId);
  }
}
