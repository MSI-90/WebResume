using Entites.Enums;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface ISocialNetworkService
  {
    IEnumerable<SocialNetworkMetadataDto> GetSocialNetworks();
  }
}
