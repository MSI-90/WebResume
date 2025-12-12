using Entites.Models;
using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects
{
  public record ContactInfoForCreationDto(
    [Phone]
    string Phone,
    [EmailAddress]
    string? Email,
    SocialNetworkDto SocialNetwork
    )
  {
  }
}
