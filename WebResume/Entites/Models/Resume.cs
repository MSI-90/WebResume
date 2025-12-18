using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
  public class Resume
  {
    public Guid Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? MiddleName { get; set; }
    public string? PurposeResume { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    [ForeignKey(nameof(Template))]
    public Guid TemplateId { get; set; }
    public Template? Template { get; set; }

    // navigation
    public Guid? PhotoId { get; set; }
    public JobInfo? Job { get; set; }
    public PersonalInfo? PersonalInfo { get; set; }
    public ContactInfo? ContactInfo { get; set; }
    public ICollection<Experience>? Experience { get; set; } = [];
    public ICollection<Education>? Education { get; set; } = [];
    public ICollection<Course>? Courses { get; set; } = [];
    public ICollection<LanguageInfo> Languages { get; set; } = [];
    public ICollection<ComputerSkill> ComputerSkill { get; set; } = [];

    //public required User User { get; set; }
  }
}
