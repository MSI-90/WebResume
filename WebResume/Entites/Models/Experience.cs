using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
  public class Experience
  {
    public Guid Id { get; set; }
    public string? JobTitle { get; set; }
    public string? CompanyName { get; set; }
    public string? JobResponsibilities { get; set; }
    public string? Achievements { get; set; }
    public DateOnly? StartJob { get; set; }
    public DateOnly? EndJob { get; set; }

    [ForeignKey(nameof(Resume))]
    public Guid ResumeId { get; set; }
    public Resume? Resume { get; set; }
  }
}
