using System.ComponentModel.DataAnnotations;

namespace Entites.Enums
{
  /// <summary>
  /// Вид шаблона
  /// </summary>
  public enum TemplateKind
  {
    [Display(Name = "Бесплатный")]
    Free,

    [Display(Name = "Платный")]
    Premium,
  }
}
