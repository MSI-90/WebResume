using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace WebResume.Presentation.Controllers
{
  [Route("api/employment-type")]
  [ApiController]
  public class EmploynmetTypeController : ControllerBase
  {
    private readonly IEmploynmetTypeService _employnmetTypeService;
    public EmploynmetTypeController(IEmploynmetTypeService employnmetTypeService)
    {
      _employnmetTypeService = employnmetTypeService;
    }

    [HttpGet]
    public ActionResult GetEmploynmetTypes()
    {
      var employmentTypes = _employnmetTypeService.GetEmploymentTypes();
      return Ok(employmentTypes);
    }
  }
}
