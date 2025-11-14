using Entites.Models;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;
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
      var resumeList = await _service.GetResumesAsync(token);
      return Ok(resumeList);
    }

    [HttpGet("{resumeId:guid}", Name = "GetResume")]
    public async Task<IActionResult> GetResume(Guid resumeId, CancellationToken token)
    {
      var resume = await _service.GetResumeAsync(resumeId, token);
      return Ok(resume);
    }

    [HttpPost]
    public async Task<IActionResult> CreateResume([FromBody] ResumeForCreationDto resumeForCreateDto)
    {
      if (resumeForCreateDto is null)
        return BadRequest($"Проблема в теле запроса");

      var resume = await _service.CreateResumeAsync(resumeForCreateDto);
      return CreatedAtRoute("GetResume", new { resumeId = resume.Id }, resume);
    }
  }
}
