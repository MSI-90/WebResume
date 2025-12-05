using AutoMapper;
using Contracts;
using Entites.Exceptions;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
  public sealed class ResumeService : IResumeService
  {
    private readonly RepositoryContext _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;
    private readonly IPhotoService _photoService;
    private readonly IFileService _fileService;
    private readonly IJobInfoService _jobInfoService;
    private readonly IBufferInfo _bufferInfo;
    private readonly IExperienceService _experienceService;
    public ResumeService(RepositoryContext repository, 
      ILoggerManager logger, 
      IMapper mapper, 
      IPhotoService photoService, 
      IJobInfoService jobInfoService, 
      IBufferInfo bufferInfo,
      IFileService fileService,
      IExperienceService experienceService)
    {
      _repository = repository;
      _logger = logger;
      _mapper = mapper;
      _photoService = photoService;
      _fileService = fileService;
      _jobInfoService = jobInfoService;
      _bufferInfo = bufferInfo;
      _experienceService = experienceService;
    }

    public async Task<IEnumerable<ResumeDto>> GetResumesAsync(CancellationToken token)
    {
      var resumes = await _repository.Resume
        .AsNoTracking()
        .Include(r => r.PhotoFile)
        .Include(r => r.Job)
        .Include(r => r.Experience)
        .ToListAsync(token);

      return _mapper.Map<IEnumerable<ResumeDto>>(resumes);
    }

    public async Task<ResumeDto> GetResumeAsync(Guid resumeId, CancellationToken token)
    {
      var resume = await _repository.Resume
        .AsNoTracking()
        .Include(r => r.PhotoFile)
        .Include(r => r.Job)
        .Include(r => r.Experience)
        .Where(r => r.Id.Equals(resumeId))
        .FirstOrDefaultAsync(token);

      return _mapper.Map<ResumeDto>(resume) ?? throw new ResumeNotFoundException(resumeId);
    }

    public async Task<ResumeDto> CreateResumeAsync(ResumeForCreationDto resumeDTO)
    {
      var newResume = _mapper.Map<Resume>(resumeDTO);
      newResume.Id = Guid.NewGuid();
      newResume.UpdatedAt = newResume.CreatedAt = DateTime.UtcNow;
      await _repository.Resume.AddAsync(newResume);
      await _repository.SaveChangesAsync();

      resumeDTO.ResumeId = newResume.Id;
      await _photoService.AddPhotoInfoAsync(resumeDTO);
      await _jobInfoService.CreateDesiredJobAsync(resumeDTO);
      await _experienceService.CreateExperienceAsync(resumeDTO);
        
      var createdResume = await GetResumeAsync(newResume.Id, default);
      return createdResume;
    }

    public async Task DeleteResumeAsync(Guid resumeId, CancellationToken token) 
    {
      var resumeForDelete = await GetResumeAsync(resumeId, token);
      await _bufferInfo.AddPhotoInfoToBuffer(resumeId, token);
      _repository.Resume.Remove(_mapper.Map<Resume>(resumeForDelete));
      await _repository.SaveChangesAsync(token);
    }
  }
}
