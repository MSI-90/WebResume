using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
  public class AdditionalInformation
  {
    public Guid Id { get; set; }
    public bool MilitaryService { get; set; }
    public bool DriverLicense { get; set; }
    public string? PersonalQualities { get; set; }
    public string? ProfessionalSkills { get; set; }
    public string? AboutYourself { get; set; }

    [ForeignKey(nameof(Resume))]
    public Guid ResumeId { get; set; }
    public Resume? Resume { get; set; }
  }
}
