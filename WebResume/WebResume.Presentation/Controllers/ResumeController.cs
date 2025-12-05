using Entites.Exceptions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Service.Contracts;
using Shared.DataTransferObjects;

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
      var resumeList = await _service.GetResumesAsync(token);
      return Ok(resumeList);
    }

    [HttpGet("{resumeId:guid}", Name = "GetResume")]
    public async Task<IActionResult> GetResume(Guid resumeId, CancellationToken token)
    {
      var resume = await _service.GetResumeAsync(resumeId, token);
      return Ok(resume);
    }

    [HttpDelete("{resumeId:guid}")]
    public async Task<IActionResult> DeleteResume(Guid resumeId, CancellationToken token)
    {
      await _service.DeleteResumeAsync(resumeId,token);
      return NoContent();
    }

    [HttpPost]
    public async Task<IActionResult> ResumeFromForm([FromForm] ResumeForCreationDto resumeForCreateDto)
    {
      var resume = await _service.CreateResumeAsync(resumeForCreateDto);
      return CreatedAtRoute("GetResume", new { resumeId = resume.Id }, resume);
    }
  }
}
