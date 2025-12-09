using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IPhotoService
  {
    bool CheckFileOnValidAsync(FileDto? file);
    Task<PhotoDto?> GetPhotoResumeAync(FileDto? file);
  }
}
