
using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
  public class ContactInfo
  {
    public Guid Id { get; set; }
    public string? Phone {  get; set; }
    public string? Email { get; set; }

    public SocialNetworkInfo? SocialNetwork { get; set; }

    [ForeignKey(nameof(Resume))]
    public Guid ResumeId { get; set; }
    public Resume? Resume { get; set; }
  }
}
