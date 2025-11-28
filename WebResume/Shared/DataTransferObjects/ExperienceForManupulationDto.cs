using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects
{
  public record ExperienceForManupulationDto
  {
    [MaxLength(100, ErrorMessage = "Максимальная длина поля составляет 100 символов")]
    public string? JobTitle { get; set; }

    [MaxLength(200, ErrorMessage = "Максимальная длина поля составляет 200 символов")]
    public string? CompanyName { get; set; }

    [MaxLength(10000, ErrorMessage = "Максимальная длина поля составляет 10000 символов")]
    public string? JobResponsibilities { get; set; }

    [MaxLength(3000, ErrorMessage = "Максимальная длина поля составляет 3000 символов")]
    public string? Achievements { get; set; }
    public DateOnly? StartJob { get; set; }
    public DateOnly? EndJob { get; set; }
  }
}
