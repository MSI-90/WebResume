using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IContactInfoService
  {
    Task CreateContactinfoAsync(ResumeForCreationDto resume);
    bool CheckContactInfoAsValid(ResumeForCreationDto resume);
    ContactInfoForCreationDto? DeserilizeContactInfo(ResumeForCreationDto resume);
  }
}
