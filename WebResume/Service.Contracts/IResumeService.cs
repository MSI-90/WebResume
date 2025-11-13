using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IResumeService
  {
    Task<IEnumerable<ResumeDto>> GetResumeAsync(CancellationToken token);
  }
}
