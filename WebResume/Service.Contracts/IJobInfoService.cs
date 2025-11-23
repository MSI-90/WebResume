using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IJobInfoService
  {
    Task<ResumeDto> CreateDesiredJobAsync(JobInfoForCreationDto jobInfo);
  }
}
