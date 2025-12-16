using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
  public class Course
  {
    public Guid? Id { get; set; }
    public string? CourseName { get; set; }
    public string? OrganizationTraining { get; set; }
    public uint? DurationOfTraining { get; set; }
    public string? Achievements { get; set; }
    public uint YearOfCompletion { get; set; }

    [ForeignKey(nameof(Resume))]
    public Guid ResumeId { get; set; }
    public Resume? Resume { get; set; }
  }
}
