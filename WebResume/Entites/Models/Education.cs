using Entites.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
  /// <summary>
  /// Образование
  /// </summary>
  public class Education
  {
    public Guid Id { get; set; }
    public string NameOfEducationalInstitution { get; set; } = string.Empty;
    public string? Faculty { get; set; }
    public string Speciality { get; set; } = string.Empty;
    public string? Achievements { get; set; }
    public uint YearOfCompletion { get; set; }
    public EducationKind EducationKind { get; set; }

    [ForeignKey(nameof(Resume))]
    public Guid ResumeId { get; set; }
    public Resume? Resume { get; set; }
  }
}
