using System.ComponentModel.DataAnnotations;

namespace Entites.Enums
{
  /// <summary>
  /// Семейное положение
  /// </summary>
  public enum MaritalStatus
  {
    [Display(Name = "Холост")]
    Single,

    [Display(Name = "Женат")]
    Married,

    [Display(Name = "Не замужем")]
    MarriedF,

    [Display(Name = "Замужем")]
    SingleF
  }
}
