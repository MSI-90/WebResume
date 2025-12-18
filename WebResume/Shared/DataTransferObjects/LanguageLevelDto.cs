namespace Shared.DataTransferObjects
{
  public record LanguageLevelDto
  {
    public string[] LevelEn { get; set; } = [];
    public string[] LevelRu { get; set; } = [];
  }
}
