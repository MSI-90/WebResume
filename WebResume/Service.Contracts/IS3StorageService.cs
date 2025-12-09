using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IS3StorageService
  {
    Task<bool> CheckBucketAsync();
    Task<(bool, string?, string?)> UploadFileAsync(FileDto? file);
    string GeneratePresignedURL(string objectKey, double duration);
    Task DeletePhotoAsync(Guid? photoId);
  }
}
