using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IFileService
  {
    Task<(string, Guid)> ReadStream(FileDto file);
  }
}
