using AutoMapper;
using Entites.Exceptions;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;
using System.Runtime;
using System.Text.Json;

namespace Service
{
  public sealed class PhotoService : IPhotoService
  {
    private readonly RepositoryContext _context;
    private readonly IFileService _fileService;
    public readonly IMapper _mapper;
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

      var allowedTypes = new[] { "image/png", "image/jpeg", "image/jpg" };
      if (!allowedTypes.Contains(file?.ContentType))
        return false;

      return true;
    }
    public async Task<Photo?> AddPhotoWithoutResumeAync(FileDto? file)
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

      return newPhoto;
    }

    public async Task<Guid?> AddPhotoInfoAsync(ResumeForCreationDto resume, Guid? resumeId)
    {
      if (string.IsNullOrEmpty(resume.PhotoFile) || string.IsNullOrWhiteSpace(resume.PhotoFile))
        return Guid.Empty;

      PhotoDto photoDto;
      try
      {
        //TODO: пересмотреть
        photoDto = JsonSerializer.Deserialize<PhotoDto>(resume.PhotoFile);
      }
      catch (Exception ex)
      {
        //_loggerManager.LogError(ex.Message);
        throw;
      }

      var newPhoto = _mapper.Map<Photo>(photoDto);
      newPhoto!.ResumeId = resumeId!.Value;
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
