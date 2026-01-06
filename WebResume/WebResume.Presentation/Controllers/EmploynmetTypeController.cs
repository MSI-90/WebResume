using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace WebResume.Presentation.Controllers
{
  [Route("api/employnment-type")]
  [ApiController]
  public class EmploynmetTypeController : ControllerBase
  {
    private readonly IEmploynmetTypeService _employnmetTypeService;
    public EmploynmetTypeController(IEmploynmetTypeService employnmetTypeService)
    {
      _employnmetTypeService = employnmetTypeService;
    }

    [HttpGet]
    [ResponseCache(Duration = 3600)]
    public ActionResult GetEmploynmetTypes()
    {
      var employmentTypes = _employnmetTypeService.GetEmploymentTypes();
      return Ok(employmentTypes);
    }
  }
}
