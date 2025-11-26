using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IFileService
  {
    Task<Photo?> GetPhotoAsync(Guid photoId, CancellationToken token);
    Task<PhotoToUpload> CreatePhotoFileAsync(FileDto file, Guid resumeId);
    Task<Guid?> AddPhotoInfoAsync(FileDto file, Guid resumeId);
    Task DeletePhotoFromStorageAsync(Guid photoId, CancellationToken token);
  }
}
