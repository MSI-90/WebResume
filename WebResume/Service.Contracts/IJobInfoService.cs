using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IJobInfoService
  {
    Task<JobInfo?> GetJobInfoAsync(Guid? jobInfoGuid, CancellationToken token);
    Task<JobInfo?> CreateDesiredJobAsync(Guid? resumeId, string? jobInfo);
  }
}
