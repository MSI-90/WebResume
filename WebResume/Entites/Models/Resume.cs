using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
  [Table("resume")]
  public class Resume
  {
    [Column("resume_id")]
    public Guid Id { get; set; }

    [Column("fio")]
    [Required(ErrorMessage = "ФИО - обязательное поле.")]
    [StringLength(50, ErrorMessage = "Максимальная длина поля ФИО составляет 50 символов.")]
    [MinLength(3, ErrorMessage = "Минимальная длина поля ФИО составляет 3 символа.")]
    public string? FIO { get; set; }

    [Column("job_title")]
    [Required(ErrorMessage = "Должность - обязательное поле.")]
    [StringLength(50, ErrorMessage = "Максимальная длина поля Должность составляет 100 символов.")]
    public string? JobTitle { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("update_at")]
    public DateTime UpdatedAt { get; set; }

    [Column("template_id")]
    [ForeignKey(nameof(Template))]
    public Guid TemplateId { get; set; }
    public Template? Template { get; set; }
    //public required User User { get; set; }
  }
}
