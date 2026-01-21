using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IEducationService
  {
    Task CreateEducationAsync(ResumeForCreationDTO resume);
    bool CheckEducationAsValid(ResumeForCreationDTO resume);
  }
}
