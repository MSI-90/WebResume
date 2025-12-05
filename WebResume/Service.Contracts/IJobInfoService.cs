using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IJobInfoService
  {
    Task<JobInfo?> GetJobInfoAsync(Guid? jobInfoGuid, CancellationToken token);
    Task<Guid?> CreateDesiredJobAsync(ResumeForCreationDto resume);
  }
}
