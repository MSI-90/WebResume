namespace Entites.Models
{
  public class Citizenship
  {
    public Guid Id { get; set; }
    public string CountryName { get; set; } = string.Empty;

    public ICollection<ResumeCitizenship> ResumesCitizenship { get; set; } = [];
  }
}
