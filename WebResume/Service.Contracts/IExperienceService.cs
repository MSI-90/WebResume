using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IExperienceService
  {
    Task<IEnumerable<Experience?>> GetExperienceAsync(Guid resumeId, CancellationToken token);
    Task CreateExperienceAsync(ResumeForCreationDTO resume);
    bool CheckExperienceAsValid(ResumeForCreationDTO resume);
  }
}
