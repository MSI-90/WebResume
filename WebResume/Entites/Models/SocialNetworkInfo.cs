using Entites.Enums;
namespace Entites.Models
{
  public class SocialNetworkInfo
  {
    public SocialKind SocialType { get; set; }
    public string SocialLink { get; set; } = string.Empty;
  }
}
