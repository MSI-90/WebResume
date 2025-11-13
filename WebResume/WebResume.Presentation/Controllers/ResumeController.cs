using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using System.Threading.Tasks;

namespace WebResume.Presentation.Controllers
{
  [Route("api/resume")]
  [ApiController]
  public class ResumeController : ControllerBase
  {
    private readonly IResumeService _service;
    public ResumeController(IResumeService service) 
    {
      _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetResumes(CancellationToken token)
    {
      try
      {
        var resumeList = await _service.GetResumeAsync(token);
        return Ok(resumeList);
      }
      catch
      {
        return StatusCode(500, "internal Server Error");
      }
    }
  }
}
