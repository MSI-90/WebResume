using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Logging;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace WebResume.Presentation.Controllers
{
  [Route("api/resume")]
  [ApiController]
  public class ResumeController : ControllerBase
  {
    private readonly IResumeService _service;
    private readonly ILogger<ResumeController> _logger;
    public ResumeController(IResumeService service, ILogger<ResumeController> logger) 
    {
      _service = service;
      _logger = logger;
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

    [HttpDelete("{resumeId:guid}")]
    public async Task<IActionResult> DeleteResume(Guid resumeId, CancellationToken token)
    {
      await _service.DeleteResumeAsync(resumeId,token);
      return NoContent();
    }

    [HttpPost("with-file")]
    public async Task<IActionResult> TaskFromForm([FromForm] ResumeForCreationDto resumeForCreateDto, IFormFile file)
    {
      if (resumeForCreateDto is null)
        return BadRequest($"Проблема в теле запроса");

      if (file is null)
        return BadRequest($"Не указан файл");

      var resume = await _service.CreateResumeAsync(resumeForCreateDto);
      return CreatedAtRoute("GetResume", new { resumeId = resume.Id }, resume);
    }
  }
}
