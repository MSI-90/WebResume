using Entites.Models;

namespace Service.Contracts
{
  public interface IExperienceService
  {
    Task<IEnumerable<Experience?>> GetExperienceAsync(Guid resumeId, CancellationToken token);
    Task<IEnumerable<Experience?>> CreateExperienceAsync(Guid resumeId, IEnumerable<string>? experience);
  }
}
