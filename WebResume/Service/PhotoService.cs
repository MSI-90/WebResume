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
    public readonly IMapper _mapper;
    public PhotoService(ILoggerManager loggerManager, RepositoryContext context, IMapper mapper) 
    {
      _context = context;
      _mapper = mapper;
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
      _context.Photos.Add(newPhoto);
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
