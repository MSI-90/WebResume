using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace WebResume.Presentation.Controllers
{
  [Route("api/citizenship")]
  [ApiController]
  public class CitizenshipController : ControllerBase
  {
    private readonly ICitizenshipService _citizenshipService;
    public CitizenshipController(ICitizenshipService citizenshipService) 
    {
      _citizenshipService = citizenshipService;
    }

    [HttpGet]
    public async Task<IActionResult> GetCitizenships(CancellationToken token)
    {
      var citizenships = await _citizenshipService.GetCitizenshipsAsync(token);
      return Ok(citizenships);
    }

    [HttpGet("{citizenshipId:guid}")]
    public async Task<IActionResult> GetCitizenship(Guid citizenshipId, CancellationToken token)
    {
      var citizenship = await _citizenshipService.GetCitizenshipAsync(citizenshipId, token);
      return Ok(citizenship);
    }

  }
}
