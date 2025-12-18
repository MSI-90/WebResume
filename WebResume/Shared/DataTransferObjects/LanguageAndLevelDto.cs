namespace Shared.DataTransferObjects
{
  public record LanguageAndLevelDto
  {
    public IEnumerable<LanguageDto> Languages { get; init; } = [];
    public LanguageLevelDto Levels { get; init; } = new();
  }
}
