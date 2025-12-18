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

    [ForeignKey(nameof(Language))]
    public Guid LanguageId { get; set; }
    public required Language Language { get; set; }
  }
}
