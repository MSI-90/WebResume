using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IPersonalInfoService
  {
    Task CreatePersonalInfoAsync(ResumeForCreationDto resumeDto);
    bool CheckPInfoAsValid(ResumeForCreationDto resumeDto);
    PersonalInfoDto? DeserializePInfo(ResumeForCreationDto resumeDto);
  }
}
