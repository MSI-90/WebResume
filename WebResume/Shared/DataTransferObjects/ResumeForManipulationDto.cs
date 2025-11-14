using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects
{
  public record ResumeForManipulationDto
  {
    [Required(ErrorMessage = "Необходимо задать значение имени.")]
    [MinLength(3, ErrorMessage = "Минимальная длина поля Имя составляет 3 символа.")]
    [StringLength(50, ErrorMessage = "Максимальная длина поля Имя составляет 50 символов.")]
    public string? FirstName { get; init; }

    [Required(ErrorMessage = "Фамилия - обязательное поле.")]
    [MinLength(3, ErrorMessage = "Минимальная длина поля Фамилия составляет 3 символа.")]
    [StringLength(70, ErrorMessage = "Максимальная длина поля Фамилия составляет 70 символов.")]
    public string? LastName { get; init; }

    [Required(ErrorMessage = "Отчество - обязательное поле.")]
    [MinLength(3, ErrorMessage = "Минимальная длина поля Отчество составляет 3 символа.")]
    [StringLength(70, ErrorMessage = "Максимальная длина поля Отчество составляет 70 символов.")]
    public string? MiddleName { get; init; }

    [Required(ErrorMessage = "Должность - обязательное поле.")]
    [MinLength(3, ErrorMessage = "Минимальная длина поля Должность составляет 3 символа.")]
    [StringLength(50, ErrorMessage = "Максимальная длина поля Должность составляет 100 символов.")]
    public string? JobTitle { get; init; }

    [Required]
    public Guid TemplateId { get; init; }
  }
}
