using Entites.Enums;

namespace Shared.DataTransferObjects
{
  public record LanguageInfoOutputDto(Guid Id, LanguageOutputDto language, LanguageLevel? Level)
  {
  }
}
