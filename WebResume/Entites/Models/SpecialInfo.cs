using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
  [Table("special_info")]
  public class SpecialInfo
  {
    [Column("special_info_id")]
    public Guid Id { get; set; }

    [Column("title")]
    [Required(ErrorMessage = "Поле Наименование обязательное для заполнения.")]
    [StringLength(30, ErrorMessage = "Максимальная длина поля составляет 30 символов.")]
    [MinLength(5, ErrorMessage = "Минимальная длина поля составляет 5 символов.")]
    public string? Title { get; set; }

    [Column("description")]
    [Required(ErrorMessage = "Поле Описание обязательное для заполнения.")]
    [StringLength(1500, ErrorMessage = "Максимальная длина поля составляет 1500 символов.")]
    [MinLength(5, ErrorMessage = "Минимальная длина поля составляет 5 символов.")]
    public string? Description { get; set; }

    //public ICollection<User>? Users { get; set; }
  }
}
