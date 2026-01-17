using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace WebResume.Presentation.Controllers
{
  [Route("api/birthday")]
  [ApiController]
  public class BirthdayController : ControllerBase
  {
    private readonly IBirthdayService _birthdayService;
    public BirthdayController(IBirthdayService birthdayService) 
    {
      _birthdayService = birthdayService;
    }

    [HttpGet]
    [ResponseCache(Duration = 3600)]
    public IActionResult GetBirthdayData()
    {
      var birthdayData = _birthdayService.GetBirthdayData();
      return Ok(birthdayData);
    }
  }
}
