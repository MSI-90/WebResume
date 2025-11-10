using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models
{
  public class Resume
  {
    [Column("resume_id")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "ФИО - обязательное поле.")]
    [MaxLength(50, ErrorMessage = "Максимальная длина поля ФИО составляет 50 символов.")]
    [MinLength(3, ErrorMessage = "Минимальная длина поля ФИО составляет 3 символа.")]
    public string? FIO { get; set; }

    [Required(ErrorMessage = "Должность - обязательное поле.")]
    [MaxLength(50, ErrorMessage = "Максимальная длина поля Должность составляет 100 символов.")]
    public string? JobTitle { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime UpdatedAt { get; set; }

    public Guid TemplateId { get; set; }
    public Template? Template { get; set; }
  }
}
