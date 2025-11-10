using Entites.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Entites.Models
{
  public class Template
  {
    [Column("template_id")]
    public Guid TemplateId { get; set; }

    [Required(ErrorMessage = "Название шаблона должно быть указано.")]
    [MinLength (3, ErrorMessage = "Минимальная длина поля сосотавляет 3 символа.")]
    [MaxLength (50, ErrorMessage = "Максимальная длина поля наименование щаблона составляет 50 символов.")]
    public string? Name { get; set; }
    public TemplateKind TemplateKind { get; set; }

    public ICollection<Resume>? ResumeList { get; set; }
  } 
}
