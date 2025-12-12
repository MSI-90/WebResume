using Entites.Enums;

namespace Shared.DataTransferObjects
{
  public record SocialNetworkDto(SocialKind SocialType, string? SocialLink)
  {
  }
}
