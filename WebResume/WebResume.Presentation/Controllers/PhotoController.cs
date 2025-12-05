using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace WebResume.Presentation.Controllers
{
  [Route("api/photo")]
  [ApiController]
  public class PhotoController : ControllerBase
  {
    private readonly IPhotoService _photoService;
    public PhotoController(IPhotoService photoService) 
    {
      _photoService = photoService;
    }

    [HttpGet]
    public IActionResult GetPhotos() 
    {
      return Ok();
    }

    [HttpPost]
    public async Task<IActionResult> AddPhoto(IFormFile? file)
    {
      FileDto? fileDto = null;
      if (file is not null)
      {
        fileDto = new FileDto
        {
          ContentType = file.ContentType,
          Length = file.Length,
          FileName = file.FileName,
          FileStream = file.OpenReadStream()
        };
      }
      var photoId = await _photoService.AddPhotoWithoutResumeAync(fileDto);
      return Ok(photoId);
    }
  }
}
