using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface ICurrencyService
  {
    IEnumerable<CurrencyDto> GetCurrencyAsync();
  }
}
