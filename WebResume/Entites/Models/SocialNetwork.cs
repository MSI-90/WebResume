namespace Entites.Models
{
  public class SocialNetwork
  {
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string IconUrl { get; set; } = string.Empty;

    public ICollection<CInfoSocNetwork>? CInfoSocNetworks { get; set; }
  }
}
