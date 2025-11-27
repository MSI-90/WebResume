using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IFileService
  {
    Task<PhotoToUpload> CreatePhotoFileAsync(FileDto file, Guid resumeId);
    Task DeletePhotoFromStorageAsync(string fileName);
  }
}
