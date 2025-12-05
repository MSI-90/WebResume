using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IPhotoService
  {
    Task<PhotoDto?> AddPhotoWithoutResumeAync(FileDto? file);
    Task<Photo?> GetPhotoAsync(Guid photoId, CancellationToken token);
    Task<Photo?> GetPhotoByResumeAsync(Guid resumeId, CancellationToken token);
    Task<Guid?> AddPhotoInfoAsync(ResumeForCreationDto resume);
  }
}
