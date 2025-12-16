using System.ComponentModel.DataAnnotations;

namespace Entites.Enums
{
  /// <summary>
  /// Вид образования
  /// </summary>
  public enum EducationKind
  {
    [Display(Name = "Среднее образование")]
    SecondaryEducation,

    [Display(Name = "Среднее-специльное образование")]
    SecondarySpecial,

    [Display(Name = "Среднее-профессиональное образование")]
    SecondaryVocational,

    [Display(Name = "Высшее образование")]
    HigherEducation
  }
}
