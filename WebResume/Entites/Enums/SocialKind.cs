using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace Entites.Enums
{
  public enum SocialKind
  {
    [Display(Name = "Behance")]
    Behance,
    [Display(Name = "Dribble")]
    Dribble,
    [Display(Name = "Facebook")]
    Facebook,
    [Display(Name = "Github")]
    Github,
    [Display(Name = "Instagram")]
    Instagram,
    [Display(Name = "Linkedin")]
    Linkedin,
    [Display(Name = "MAX")]
    MAX,
    [Display(Name = "Skype")]
    Skype,
    [Display(Name = "Telegram")]
    Telegram,
    [Display(Name = "Viber")]
    Viber,
    [Display(Name = "VK")]
    VK,
    [Display(Name = "Whatsapp")]
    Whatsapp
  }
}
