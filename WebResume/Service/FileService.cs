using Contracts;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;
using AutoMapper;
using Entites.Models;

namespace Service
{
  public sealed class FileService : IFileService
  {
    private readonly ILoggerManager _loggerManager;
    private readonly RepositoryContext _context;
    private readonly string _filePath;
    public readonly IMapper _mapper;
    public FileService(string filePath, ILoggerManager loggerManager, RepositoryContext context, IMapper mapper) 
    {
      _filePath = filePath;
      _loggerManager = loggerManager;
      _context = context;
      _mapper = mapper;
    }

    public async Task<PhotoToUpload> CreatePhotoFileAsync(FileDto file)
    {
      if (file is null || file?.FileStream is null)
        throw new ArgumentNullException(nameof(file));

      Directory.CreateDirectory(_filePath);
      var fileName = $"{Guid.NewGuid()}{Path.GetExtension(file?.FileName)}";
      var filePath = Path.Combine(_filePath, fileName);

      try
      {
        using var stream = new FileStream(filePath, FileMode.Create);
        await file.FileStream.CopyToAsync(stream);
        
        var photoId = await AddPhotoInfoAsync(file);
        return new PhotoToUpload(fileName, photoId, _filePath);

      } catch (Exception ex)
      {
        _loggerManager.LogError($"File is not created {ex.Message}");
        if (File.Exists(filePath))
          File.Delete(filePath);
        throw;
      }
    }

    public async Task<Guid?> AddPhotoInfoAsync(FileDto file)
    {
      var newPhoto = new Photo 
      {
        Id = Guid.NewGuid(), 
        FileName = file.FileName, 
        Length = file.Length
      };
      _context.Photos.Add(newPhoto);
      await _context.SaveChangesAsync();
      return newPhoto.Id;
    }
  }
}
