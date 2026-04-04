using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

// TODO: Рассмотреть вопрос переноса этого и подобных контроллеров в отдельный микросервис.
// TODO: Вообще в рамках этой задачи лучше всего перенести подобныце отдельные методы
// реализованные для решения бизнесс задачи в сервис который непосредственно с ней связан.
namespace WebResume.Presentation.Controllers
{
  [Route("api/work-schedule")]
  [ApiController]
  public class WorkSheduleController : ControllerBase
  {
    private readonly IWorkSheduleService _workSheduleService;
    public WorkSheduleController(IWorkSheduleService workSheduleService)
    {
      _workSheduleService = workSheduleService;
    }

    [HttpGet]
    public IActionResult GetWorkShedule()
    {
      var workShedule = _workSheduleService.GetWorkShedule();
      return Ok(workShedule);
    }
  }
}
