using System.ComponentModel.DataAnnotations;

namespace Entites.Enums
{
  /// <summary>
  /// Валюта
  /// </summary>
  public enum Currency
  {
    [Display(Name = "Рублей")]
    RUB = 810,

    [Display(Name = "Долларов США")]
    USD = 840,

    [Display(Name = "Евро")]
    EUR = 978,

    [Display(Name = "Тенге")]
    KZT = 398,

    [Display(Name = "Сум")]
    UZS = 860,

    [Display(Name = "Сомони")]
    TJS = 972,

    [Display(Name = "Белорусских рублей")]
    BYN = 933,

    [Display(Name = "Драм")]
    AMD = 051,
  }
}
