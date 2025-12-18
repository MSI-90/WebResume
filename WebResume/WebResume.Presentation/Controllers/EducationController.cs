using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace WebResume.Presentation.Controllers
{
  [Route("api/education")]
  [ApiController]
  public class EducationController : ControllerBase
  {
    private readonly IEducationCourse<EducationYearAndKindDto> _edcourse;
    public EducationController(IEducationCourse<EducationYearAndKindDto> ecourse)
    {
      _edcourse = ecourse;
    }

    [HttpGet]
    [ResponseCache(Duration = 3600)]
    public IActionResult GetEducationYearAndKinds()
    {
      var educationYearAndKinds = _edcourse.GetEducationYearAndKinds();
      return Ok(educationYearAndKinds);
    }
  }
}
