using System.ComponentModel.DataAnnotations;

namespace Entites.Enums
{
  public enum SocialKind
  {
    [Display(Name = "Whatsapp")]
    Whatsapp = 0,
    [Display(Name = "Viber")]
    Viber = 1,
    [Display(Name = "Telegram")]
    Telegram = 2,
    [Display(Name = "VK")]
    VK = 3,
    [Display(Name = "Skype")]
    Skype = 4,
    [Display(Name = "Linkedin")]
    Linkedin = 5,
    [Display(Name = "Instagram")]
    Instagram = 6,
    [Display(Name = "Github")]
    Github = 7,
    [Display(Name = "Facebook")]
    Facebook = 8,
    [Display(Name = "Dribble")]
    Dribble = 9,
    [Display(Name = "Behance")]
    Behance = 10
  }
}
