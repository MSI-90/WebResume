using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface ICourseService
  {
    Task CreateCourseAsync(ResumeForCreationDTO resume);
    bool CheckCourseAsValid(ResumeForCreationDTO resume);
  }
}
