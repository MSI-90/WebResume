namespace Entites.Models
{
  public class CInfoSocNetwork
  {
    public Guid ContactInfoId { get; set; }
    public Guid SocialNetworkId { get; set; }
    public string LinkOnSocialNetwork { get; set; } = string.Empty;

    public ContactInfo? ContactInfo { get; set; }
    public SocialNetwork? SocialNetwork { get; set; }
  }
}
