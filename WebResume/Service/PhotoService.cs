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
    private readonly ILoggerManager _loggerManager;
    private readonly RepositoryContext _context;
    private readonly string _filePath;
    public readonly IMapper _mapper;
    public PhotoService(string filePath, ILoggerManager loggerManager, RepositoryContext context, IMapper mapper) 
    {
      _filePath = filePath;
      _loggerManager = loggerManager;
      _context = context;
      _mapper = mapper;
    }

    public async Task<PhotoToUpload> CreatePhotoFileAsync(FileDto file, Guid resumeId)
    {
      if (file is null || file?.FileStream is null)
        throw new ArgumentNullException(nameof(file));

      Directory.CreateDirectory(_filePath);
      var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file?.FileName ?? "")}";
      var filePath = Path.Combine(_filePath, fileName);

      try
      {
        using var stream = new FileStream(filePath, FileMode.Create);
        await file!.FileStream.CopyToAsync(stream);

        file.FileName = fileName;
        var photoId = await AddPhotoInfoAsync(file, resumeId);
        return new PhotoToUpload(fileName, photoId, _filePath);

      } catch (Exception ex)
      {
        _loggerManager.LogError($"File is not created {ex.Message}");
        if (File.Exists(filePath))
          File.Delete(filePath);
        throw;
      }
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

    public async Task DeletePhotoFromStorageAsync(Guid photoId, CancellationToken token)
    {
      var photo = await GetPhotoAsync(photoId, token);
      string? directoryPath = Path.GetDirectoryName(_filePath);
      string? fileName = photo?.FileName;
      try
      {
        string? filePath = Path.Combine(directoryPath, fileName);

        if (File.Exists(filePath))
        {
          File.Delete(filePath);
          _loggerManager.LogInfo($"Файл {fileName}");
        }
        else
          _loggerManager.LogWarn($"Файл {fileName} не найден");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Ошибка при удалении: {ex.Message}");
      }
    }
  }
}
