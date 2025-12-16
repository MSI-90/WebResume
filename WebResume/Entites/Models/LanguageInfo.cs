using Entites.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
  public class LanguageInfo
  {
    public Guid Id { get; set; }
    public LanguageLevel? Level { get; set; }

    [ForeignKey(nameof(Resume))]
    public Guid ResumeId { get; set; }
    public Resume? Resume { get; set; }

    public Language? Language { get; set; }
  }
}
