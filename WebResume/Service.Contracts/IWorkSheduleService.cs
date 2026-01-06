using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IWorkSheduleService
  {
    IEnumerable<WorkSheduleDto> GetWorkShedule();
  }
}
