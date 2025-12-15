using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace WebResume.Presentation.Controllers
{
  [Route("api/education")]
  [ApiController]
  public class EducationController : ControllerBase
  {
    private readonly IEducationService _educationService;
    public EducationController(IEducationService educationService)
    {
      _educationService = educationService;
    }

    [HttpGet]
    public IActionResult GetEducationYearAndKinds()
    {
      var educationYearAndKinds = _educationService.GetEducationYearAndKinds();
      return Ok(educationYearAndKinds);
    }
  }
}
