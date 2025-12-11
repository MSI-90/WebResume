using Entites.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
  public class PersonalInfo
  {
    public Guid Id { get; set; }
    public string? City { get; set; }
    public bool IsDualCitizenship { get; set; }
    public DateOnly Birthday { get; set; }
    public bool IsChildren { get; set; }
    public Sex Sex { get; set; }
    public Moving Moving { get; set; }
    public MaritalStatus MaritalStatus { get; set; }

    [ForeignKey(nameof(Resume))]
    public Guid? ResumeId { get; set; }
    public Resume? Resume { get; set; }

    public HashSet<Citizenship> Citizenships { get; set; } = [];
  }
}
