using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
  public class Portfolio
  {
    public Guid Id { get; set; }
    public string? Description { get; set; }
    public string? Url { get; set; }

    [ForeignKey(nameof(Resume))]
    public Guid ResumeId { get; set; }
    public Resume? Resume { get; set; }
  }
}
