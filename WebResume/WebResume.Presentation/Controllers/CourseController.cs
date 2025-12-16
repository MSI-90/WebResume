using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace WebResume.Presentation.Controllers
{
  [Route("api/course")]
  [ApiController]
  public class CourseController : ControllerBase
  {
    private readonly IEducationCourse<CourseYearDto> _edcourse;
    public CourseController(IEducationCourse<CourseYearDto> edcourse) 
    {
      _edcourse = edcourse;
    }

    [HttpGet]
    public IActionResult GetCourseYear() 
    {
      var courseYear = _edcourse.GetEducationYearAndKinds();
      return Ok(courseYear);
    }
  }
}
