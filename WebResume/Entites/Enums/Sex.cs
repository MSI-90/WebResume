using System.ComponentModel.DataAnnotations;

namespace Entites.Enums
{
  /// <summary>
  /// Пол
  /// </summary>
  public enum Sex
  {
    [Display(Name = "Мужской")]
    Male,

    [Display(Name = "Женский")]
    Female
  }
}
