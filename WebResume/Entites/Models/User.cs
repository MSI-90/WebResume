using Entites.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
  public class User
  {
    [Column("status")]
    public UserStatus Status { get; set; }

    [Column("special_info")]
    public SpecialInfo? SpecialInfo { get; set; }
    public string? RefreshToken { get; set; }
    public DateTime RefreshTokenExpiryTime { get; set; }

    public ICollection<SpecialInfo>? SpecialInfos { get; set; }
    public ICollection<Resume>? Resumes { get; set; }
  }
}
