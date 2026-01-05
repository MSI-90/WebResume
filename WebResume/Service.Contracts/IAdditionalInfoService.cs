using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IAdditionalInfoService
  {
    Task CreateAdditionalInfoAsync(ResumeForCreationDto resume);
    bool CheckAdditionalInfoAsValid(ResumeForCreationDto resume);
    AdditionalInfoForCreationDto? DeserializeAdditionalInfo(ResumeForCreationDto resume);
  }
}
