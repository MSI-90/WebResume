using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IEducationCourse<T>
  {
    T? GetEducationYearAndKinds();
  }
}
