namespace Entites.Models
{
  public class Citizenship
  {
    public Guid Id { get; set; }
    public string CountryName { get; set; } = string.Empty;
    public string CountryNameRu {  get; set; } = string.Empty;
    public string Alpha2Code {  get; set; } = string.Empty;
    public string Alpha3Code {  get; set; } = string.Empty;
    public string NumericCode {  get; set; } = string.Empty;

    public ICollection<PersonalInfoCitizenship> PersonalInfos { get; set; } = [];
  }
}
