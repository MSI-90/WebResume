using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace WebResume.Presentation.Controllers
{
  [Route("api/currency")]
  [ApiController]
  public class CurrencyController : ControllerBase
  {
    private readonly ICurrencyService _currencyService;
    public CurrencyController(ICurrencyService currencyService) 
    {
      _currencyService = currencyService;
    }

    [HttpGet]
    public IActionResult GetCurrencies()
    {
      var currencies = _currencyService.GetCurrencyAsync();
      return Ok(currencies);
    }
  }
}
