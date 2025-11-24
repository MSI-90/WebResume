using System.ComponentModel.DataAnnotations;

namespace Entites.Enums
{
  /// <summary>
  /// Статус пользователя
  /// </summary>
  public enum UserStatus
  {
    [Display(Name = "Бесплатный план")]
    Free,

    [Display(Name = "Премиум план")]
    Premium
  }
}
