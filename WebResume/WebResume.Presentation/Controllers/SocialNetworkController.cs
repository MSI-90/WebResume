using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace WebResume.Presentation.Controllers
{
  [ApiController]
  [Route("api/social")]
  public class SocialNetworkController : ControllerBase
  {
    private readonly ISocialNetworkService _social;
    public SocialNetworkController(ISocialNetworkService social) 
    {
      _social = social;
    }

    [HttpGet]
    public ActionResult GetSocialNetworks() 
    {
      return Ok(_social.GetSocialNetworks());
    }
  }
}
