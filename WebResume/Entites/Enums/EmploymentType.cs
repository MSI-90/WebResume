using System.ComponentModel.DataAnnotations;

namespace Entites.Enums
{
  public enum EmploymentType
  {
    [Display(Name = "Полная занятость")]
    FullTime,

    [Display(Name = "Частичная занятость")]
    PartTime,

    [Display(Name = "Фриланс")]
    Freelance,

    [Display(Name = "Временная работа")]
    Temporary,

    [Display(Name = "Стажировка")]
    Internship,

    [Display(Name = "Проектная работа")]
    Project,

    [Display(Name = "Сменный график")]
    Shift,

    [Display(Name = "Удалённая работа")]
    Remote,

    [Display(Name = "Гибрид")]
    Hybrid
  }
}
