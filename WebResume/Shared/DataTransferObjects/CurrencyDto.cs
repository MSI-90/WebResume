using Entites.Enums;

namespace Shared.DataTransferObjects
{
  public record CurrencyDto(string CurrencyName, string CurrencyNameRu, uint CurrencyCode)
  {
  }
}
