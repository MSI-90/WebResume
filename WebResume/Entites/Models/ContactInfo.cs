
using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
  public class ContactInfo
  {
    public Guid Id { get; set; }
    public uint Phone {  get; set; }
    public required string Email { get; set; }


    [ForeignKey(nameof(Resume))]
    public Guid ResumeId { get; set; }
    public Resume? Resume { get; set; }

    public ICollection<CInfoSocNetwork>? SocNetwork { get; set; } 
  }
}
