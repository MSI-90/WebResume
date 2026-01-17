using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace WebResume.Presentation.Controllers
{
  [Route("api/personal")]
  [ApiController]
  public class PersonalInfoController : ControllerBase
  {
    private readonly IPersonalInfoService _personalInfoService;
    public PersonalInfoController(IPersonalInfoService personalInfoService)
    {
      _personalInfoService = personalInfoService;
    }

    [HttpGet("moving-variant")]
    public IActionResult GetMovingVariant()
    {
      var movingVariants = _personalInfoService.MovingVariants();
      return Ok(movingVariants);
    }

    [HttpGet("sex")]
    public IActionResult GetSexVariant()
    {
      var sexVariants = _personalInfoService.SexVariant();
      return Ok(sexVariants);
    }

    [HttpGet("marital-status")]
    public IActionResult GetMaritalStatus()
    {
      var maritalStatus = _personalInfoService.MaritalStatusVariants();
      return Ok(maritalStatus);
    }
  }
}
