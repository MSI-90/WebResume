using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IAdditionalInfoService
  {
    Task CreateAdditionalInfoAsync(ResumeForCreationDTO resume);
    bool CheckAdditionalInfoAsValid(ResumeForCreationDTO resume);
  }
}
