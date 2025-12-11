using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IJobInfoService
  {
    Task<JobInfo?> GetJobInfoAsync(Guid? jobInfoGuid, CancellationToken token);
    Task CreateDesiredJobAsync(ResumeForCreationDto resume);
    bool CheckDesiredJobAsValid(ResumeForCreationDto resume);
    DesiredJobInfoForCreationDto? DeserilizeDesiredJob(ResumeForCreationDto resume);
  }
}
