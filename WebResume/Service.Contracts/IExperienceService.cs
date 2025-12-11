using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IExperienceService
  {
    Task<IEnumerable<Experience?>> GetExperienceAsync(Guid resumeId, CancellationToken token);
    Task CreateExperienceAsync(ResumeForCreationDto resume);
    bool CheckExperienceAsValid(ResumeForCreationDto resume);
    List<Experience> DeserialiseExperience(ResumeForCreationDto resume);
  }
}
