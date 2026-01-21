using Entites.Models;
using System.ComponentModel.DataAnnotations;

namespace Shared.DataTransferObjects
{
  public record ContactInfoForCreationDto(
    [Phone(ErrorMessage = "Укажите, пожалуйста номер телефона")]
    string? Phone,
    [EmailAddress]
    string Email,
    SocialNetworkDto? SocialNetwork
    )
  {
  }
}
