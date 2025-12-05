using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IExperienceService
  {
    Task<IEnumerable<Experience?>> GetExperienceAsync(Guid resumeId, CancellationToken token);
    Task<IEnumerable<Experience?>> CreateExperienceAsync(ResumeForCreationDto resume);
  }
}
