using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IFileService
  {
    Task<PhotoToUpload> CreatePhotoFileAsync(FileDto file);
    Task<Guid?> AddPhotoInfoAsync(FileDto file);
  }
}
