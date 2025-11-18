using AutoMapper;
using Contracts;
using Entites.Exceptions;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;
using System.IO;

namespace Service
{
  public sealed class ResumeService : IResumeService
  {
    private readonly RepositoryContext _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;
    private readonly IFileService _fileService;
    public ResumeService(RepositoryContext repository, ILoggerManager logger, IMapper mapper, IFileService fileService)
    {
      _repository = repository;
      _logger = logger;
      _mapper = mapper;
      _fileService = fileService;
    }

    public async Task<IEnumerable<ResumeDto>> GetResumesAsync(CancellationToken token)
    {
      var resumes = await _repository.Resume.AsNoTracking().ToListAsync(token);
      return _mapper.Map<IEnumerable<ResumeDto>>(resumes);
    }

    public async Task<ResumeDto> GetResumeAsync(Guid resumeId, CancellationToken token)
    {
      var resume = await _repository.Resume
        .AsNoTracking()
        .Where(r => r.Id.Equals(resumeId))
        .FirstOrDefaultAsync(token);

      return _mapper.Map<ResumeDto>(resume) ?? throw new ResumeNotFoundException(resumeId);
    }

    public async Task<ResumeDto> CreateResumeAsync(ResumeForCreationDto resume, FileDto? file = null)
    {

      if (file is not null)
        await _fileService.ReadStream(file);

      var newResume = _mapper.Map<Resume>(resume);
      newResume.Id = Guid.NewGuid();
      newResume.UpdatedAt = newResume.CreatedAt = DateTime.UtcNow;
      _repository.Resume.Add(newResume);
      await _repository.SaveChangesAsync();

      var createdResume = await GetResumeAsync(newResume.Id, default);
      return createdResume;
    }

    public async Task DeleteResumeAsync(Guid resumeId, CancellationToken token) 
    {
      var resumeForDelete = await GetResumeAsync(resumeId, token);
      _repository.Resume.Remove(_mapper.Map<Resume>(resumeForDelete));
      await _repository.SaveChangesAsync(token);
    }
  }
}
