using System.ComponentModel.DataAnnotations;

namespace Entites.Enums
{
  /// <summary>
  /// Переезд
  /// </summary>
  public enum Moving
  {
    [Display(Name = "Возможен")]
    Possible,

    [Display(Name = "Невозможен")]
    Impossible,

    [Display(Name = "Нежелателен")]
    Undesirable
  }
}
