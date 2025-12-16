namespace Entites.Models
{
  public class Language
  {
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string NameRu { get; set; } = string.Empty;
    public string IsoCode { get; set; } = string.Empty;

    public ICollection<LanguageInfo>? LanguageInfos { get; set; } = [];
  }
}
