using Contracts;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;
using AutoMapper;
using Entites.Models;
using Microsoft.EntityFrameworkCore;

namespace Service
{
  public sealed class PhotoService : IPhotoService
  {
    private readonly RepositoryContext _context;
    private readonly IFileService _fileService;
    public readonly IMapper _mapper;
    //private Guid? photoId;
    //public Guid? PhotoId
    //{
    //  get { return photoId; }
    //  private set
    //  {
    //    photoId = value;
    //  }
    //}
    public PhotoService(RepositoryContext context, IFileService fileService, IMapper mapper) 
    {
      _context = context;
      _fileService = fileService;
      _mapper = mapper;
    }

    public bool CheckFileOnValidAsync(FileDto? file) 
    {
      if (file?.Length == 0 || file?.Length > 3000000)
        return false;

      try
      {
        var fileExtension = Path.GetExtension(file?.FileName)?.ToLowerInvariant();
        if (file?.ContentType != "image/png" && file?.ContentType != "image/jpeg")
          return false;
      }
      catch (Exception ex) 
      {
        throw new Exception(ex.Message);
      }
      return true;
    }
    public async Task<Guid?> AddPhotoWithoutResumeAync(FileDto? file)
    {
      var checkFile = CheckFileOnValidAsync(file);
      if (!checkFile) 
        return null;

      var photoOnDirectory = await _fileService.CreatePhotoFileAsync(file!);
      var newPhoto = new Photo
      {
        Id = Guid.NewGuid(),
        FileName = photoOnDirectory.FileName,
        Length = file!.Length
      };

      return newPhoto.Id;
      //PhotoId = newPhoto.Id;
      //return PhotoId;
    }

    public async Task<Guid?> AddPhotoInfoAsync(FileDto file, Guid resumeId)
    {
      var newPhoto = new Photo 
      {
        Id = Guid.NewGuid(), 
        FileName = file.FileName, 
        Length = file.Length
      };

      newPhoto.ResumeId = resumeId;
      await _context.Photos.AddAsync(newPhoto);
      await _context.SaveChangesAsync();
      return newPhoto.Id;
    }

    public async Task<Photo?> GetPhotoAsync(Guid photoId, CancellationToken token)
    {
      var photo = await _context.Photos
        .Where(p => p.Id.Equals(photoId))
        .FirstOrDefaultAsync(token);

      return photo;
    }

    public async Task<Photo?> GetPhotoByResumeAsync(Guid resumeId, CancellationToken token)
    {
      var photo = await _context.Photos
        .Where(p => p.ResumeId.Equals(resumeId))
        .FirstOrDefaultAsync(token);

      return photo;
    }
  }
}
