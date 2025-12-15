using System.ComponentModel.DataAnnotations;

namespace Entites.Enums
{
  /// <summary>
  /// Форма обучения
  /// </summary>
  public enum FormOfStudy
  {
    [Display(Name = "Очная")]
    FullTime,

    [Display(Name = "Заочная")]
    PartTime,

    [Display(Name = "Очно-Заочная (вечерняя)")]
    Parttime_evening,

    [Display(Name = "Дистанционная")]
    DistanceLearning
  }
}
