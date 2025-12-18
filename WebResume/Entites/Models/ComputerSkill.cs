using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
  public class ComputerSkill
  {
    public Guid Id { get; set; }
    public string? Title { get; set; }

    [ForeignKey(nameof (Resume))]
    public Guid ResumeId { get; set; }
    public Resume? Resume { get; set; }
  }
}
