using System.ComponentModel.DataAnnotations;

namespace Entites.Enums
{
  public enum LanguageLevel
  {
    [Display(Name = "А1 - начальный")]
    Beginner,

    [Display(Name = "А2 - elementary")]
    Elementary,

    [Display(Name = "B1 - средний")]
    Middle,

    [Display(Name = "B2 - средне-продвинутый")]
    IntermediateAdvanced,

    [Display(Name = "C1 - продвинутый")]
    Advanced,

    [Display(Name = "C2 - в совершенстве")]
    Perfectly
  }
}
