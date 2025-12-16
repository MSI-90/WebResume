using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface ICourseService
  {
    Task CreateCourseAsync(ResumeForCreationDto resume);
    bool CheckCourseAsValid(ResumeForCreationDto resume);
    List<Course> DeserialiseCourse(ResumeForCreationDto resume);
  }
}
