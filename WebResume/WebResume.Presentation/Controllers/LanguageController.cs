using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace WebResume.Presentation.Controllers
{
  [Route("api/languages")]
  [ApiController]
  public class LanguageController : ControllerBase
  {
    private readonly ILanguageService _languageService;
    public LanguageController(ILanguageService languageService)
    {
      _languageService = languageService;
    }

    [HttpGet]
    public async Task<IActionResult> GetLanguages()
    {
      var languagesAnLevels = await _languageService.GetLanguageLevelAsync();
      return Ok(languagesAnLevels);
    }
  }
}
