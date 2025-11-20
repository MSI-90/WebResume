using System.ComponentModel.DataAnnotations;

namespace Entites.Enums
{
  public enum WorkShedule
  {
    [Display(Name = "Полный день")]
    FullDay,

    [Display(Name = "Гибкий график")]
    Flexible,

    [Display(Name = "Сменный график")]
    Shift,

    [Display(Name = "Вахтовый метод")]
    ShiftMethod,

    [Display(Name = "Неполный рабочий день")]
    PartTime,

    [Display(Name = "По выходным")]
    Weekends,

    [Display(Name = "По вечерам")]
    Evenings,

    [Display(Name = "По ночам")]
    Nights,

    [Display(Name = "Без выходных")]
    NoWeekends,

    [Display(Name = "Разовый заказ")]
    OneTime
  }
}
