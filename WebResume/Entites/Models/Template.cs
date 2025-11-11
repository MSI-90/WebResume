using Entites.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
  [Table("template")]
  public class Template
  {
    [Column("template_id")]
    public Guid TemplateId { get; set; }

    [Column("name")]
    [Required(ErrorMessage = "Название шаблона должно быть указано.")]
    [MinLength (3, ErrorMessage = "Минимальная длина поля сосотавляет 3 символа.")]
    [StringLength(50, ErrorMessage = "Максимальная длина поля наименование щаблона составляет 50 символов.")]
    public string? Name { get; set; }

    [Column("template_kind")]
    public TemplateKind TemplateKind { get; set; }

    public ICollection<Resume>? Resumes { get; set; }
  } 
}
