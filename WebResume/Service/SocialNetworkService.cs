using Entites.Enums;
using Microsoft.Extensions.Logging;
using Service.Contracts;
using Shared.DataTransferObjects;


namespace Service
{
  public sealed class SocialNetworkService : ISocialNetworkService
  {
    private readonly ILogger<SocialNetworkService> _logger;
    public SocialNetworkService(ILogger<SocialNetworkService> logger)
    {
      _logger = logger;
    }

    public IEnumerable<SocialNetworkMetadataDto> GetSocialNetworks()
    {
      var socials = Enum.GetValues<SocialKind>();
      var socialsAsList = new List<SocialNetworkMetadataDto>();
      uint i = 0;
      while (i != socials.Length)
      {
        socialsAsList.Add(new SocialNetworkMetadataDto(i, socials[i].ToString(), $"{socials[i].ToString().ToLowerInvariant()}.svg"));
        i++;
      }
      return socialsAsList;
    }
  }
}
