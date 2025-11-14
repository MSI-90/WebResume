using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IResumeService
  {
    Task<IEnumerable<ResumeDto>> GetResumesAsync(CancellationToken token);
    Task<ResumeDto> GetResumeAsync(Guid resumeId, CancellationToken token);
  }
}
