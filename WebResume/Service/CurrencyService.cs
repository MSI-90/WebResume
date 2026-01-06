using Entites.Enums;
using Entites.Enums.Extends;
using Microsoft.Extensions.Logging;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
  public sealed class CurrencyService : ICurrencyService
  {
    private readonly ILogger<ContactInfoService> _logger;
    public CurrencyService(ILogger<ContactInfoService> logger) 
    {
      _logger = logger;
    }

    public IEnumerable<CurrencyDto> GetCurrencyAsync()
    {
      var currencies = Enum.GetValues<Currency>();
      var currenciesAsList = new List<CurrencyDto>();
      uint i = 0;
      while (i != currencies.Length)
      {
        currenciesAsList.Add(new CurrencyDto(currencies[i].ToString(), currencies[i].GetDisplayName(), (uint)currencies[i]));
        i++;
      }
      return currenciesAsList;
    }
  }
}
