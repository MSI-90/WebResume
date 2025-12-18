using Entites.Enums;
namespace Shared.DataTransferObjects
{
  public record LanguageForCreationDto(LanguageLevel? Level, Guid LanguageId)
  {
  }
}
