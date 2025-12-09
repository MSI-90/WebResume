using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
  [Table("resume")]
  public class Resume
  {
    [Column("resume_id")]
    public Guid Id { get; set; }

    [Column("first_name")]
    [Required(ErrorMessage = "Имя - обязательное поле.")]
    [StringLength(50, ErrorMessage = "Максимальная длина поля Имя составляет 50 символов.")]
    [MinLength(3, ErrorMessage = "Минимальная длина поля Имя составляет 3 символа.")]
    public string? FirstName { get; set; }

    [Column("last_name")]
    [Required(ErrorMessage = "Фамилия - обязательное поле.")]
    [StringLength(70, ErrorMessage = "Максимальная длина поля Фамилия составляет 70 символов.")]
    [MinLength(3, ErrorMessage = "Минимальная длина поля Фамилия составляет 3 символа.")]
    public string? LastName { get; set; }

    [Column("middle_name")]
    [StringLength(70, ErrorMessage = "Максимальная длина поля Отчество составляет 70 символов.")]
    [MinLength(3, ErrorMessage = "Минимальная длина поля Отчество составляет 3 символа.")]
    public string? MiddleName { get; set; }

    [Column("purpose_resume")]
    [StringLength(500, ErrorMessage = "Максимальная длина для поля Целю резюме составляет 500 символов.")]
    public string? PurposeResume { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("update_at")]
    public DateTime UpdatedAt { get; set; }

    // navigation
    public JobInfo? Job { get; set; }
    public Guid? PhotoId { get; set; }
    public PersonalInfo? PersonalInfo { get; set; }
    public ICollection<ResumeCitizenship> ResumeCitizenship { get; set; } = [];
    public ICollection<Experience?> Experience { get; set; } = [];

    [Column("template_id")]
    [ForeignKey(nameof(Template))]
    public Guid TemplateId { get; set; }
    public Template? Template { get; set; }
    //public required User User { get; set; }
  }
}
