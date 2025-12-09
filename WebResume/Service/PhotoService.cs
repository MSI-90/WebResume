using AutoMapper;
using Entites.Exceptions;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;
using System.Text.Json;

namespace Service
{
  public sealed class PhotoService : IPhotoService
  {
    private readonly RepositoryContext _context;
    public readonly IMapper _mapper;

    private readonly IS3StorageService _s3;
    public PhotoService(RepositoryContext context, IMapper mapper, IS3StorageService s3) 
    {
      _context = context;
      _mapper = mapper;
      _s3 = s3;
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
    public async Task<PhotoDto?> AddPhotoWithoutResumeAync(FileDto? file)
    {
      var checkFile = CheckFileOnValidAsync(file);
      if (!checkFile)
        throw new PhotoSizeException();

      var putPhotoOnBucket = await _s3.UploadFileAsync(file);

      PhotoDto? newPhoto = null;
      if (putPhotoOnBucket.Item1)
        newPhoto = new PhotoDto(new Guid(putPhotoOnBucket.Item2 ?? ""), putPhotoOnBucket.Item3);

      return newPhoto;
    }
  }
}
