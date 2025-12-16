using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IEducationService
  {
    Task CreateEducationAsync(ResumeForCreationDto resume);
    bool CheckEducationAsValid(ResumeForCreationDto resume);
    List<Education> DeserialiseEducation(ResumeForCreationDto resume);
  }
}
