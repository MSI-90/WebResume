using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace WebResume.Presentation.Controllers
{
  [Route("api/template")]
  [ApiController]
  public class TemplateController : ControllerBase
  {
    private readonly ITemplateService _templateService;
    public TemplateController(ITemplateService templateService) 
    {
      _templateService = templateService;
    }

    [HttpGet] 
    public async Task<IActionResult> GetTemplates(CancellationToken token)
    {
      var templates = await _templateService.GetTemplatesAsync(token);
      return Ok(templates);
    }
  }
}
