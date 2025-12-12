using Entites.Enums;

namespace Shared.DataTransferObjects
{
  public record SocialNetworkOutputDto(SocialKind SocialType, string? SocialLink)
  {
  }
}
