using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IEmploynmetTypeService
  {
    IEnumerable<EmploynmetTypeDto> GetEmploymentTypes();
  }
}
