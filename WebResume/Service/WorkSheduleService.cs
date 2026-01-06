using Entites.Enums;
using Entites.Enums.Extends;
using Microsoft.Extensions.Logging;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
  public sealed class WorkSheduleService : IWorkSheduleService
  {
    private readonly ILogger<WorkSheduleService> _logger;
    public WorkSheduleService(ILogger<WorkSheduleService> logger) 
    {
      _logger = logger;
    }

    public IEnumerable<WorkSheduleDto> GetWorkShedule()
    {
      var workShedules = Enum.GetValues<WorkSchedule>();
      uint i = 0;
      return workShedules
        .Select(ws => new WorkSheduleDto(i++, ws.ToString(), ws.GetDisplayName()))
        .ToList();
    }
  }
}
