using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IContactInfoService
  {
    Task CreateContactinfoAsync(ResumeForCreationDTO resume);
    bool CheckContactInfoAsValid(ResumeForCreationDTO resume);
  }
}
