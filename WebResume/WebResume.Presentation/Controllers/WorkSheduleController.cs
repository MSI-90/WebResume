using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace WebResume.Presentation.Controllers
{
  [Route("api/WorkShedule")]
  [ApiController]
  public class WorkSheduleController : ControllerBase
  {
    private readonly IWorkSheduleService _workSheduleService;
    public WorkSheduleController(IWorkSheduleService workSheduleService)
    {
      _workSheduleService = workSheduleService;
    }

    [HttpGet]
    [ResponseCache(Duration = 3600)]
    public IActionResult GetWorkShedule()
    {
      var workShedule = _workSheduleService.GetWorkShedule();
      return Ok(workShedule);
    }
  }
}
