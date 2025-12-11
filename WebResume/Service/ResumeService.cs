using AutoMapper;
using Entites.Exceptions;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
  public sealed class ResumeService : IResumeService
  {
    private readonly RepositoryContext _repository;
    private readonly ILogger _logger;
    private readonly IMapper _mapper;
    private readonly IJobInfoService _jobInfoService;
    private readonly IExperienceService _experienceService;
    private readonly IS3StorageService _s3;
    private readonly IPersonalInfoService _personalInfoService;
    public ResumeService(RepositoryContext repository, 
      ILogger<ResumeService> logger, 
      IMapper mapper, 
      IPhotoService photoService, 
      IJobInfoService jobInfoService, 
      IExperienceService experienceService,
      IS3StorageService s3,
      IPersonalInfoService personalInfoService)
    {
      _repository = repository;
      _logger = logger;
      _mapper = mapper;
      _jobInfoService = jobInfoService;
      _experienceService = experienceService;
      _s3 = s3;
      _personalInfoService = personalInfoService;
    }

    public async Task<IEnumerable<ResumeDto>> GetResumesAsync(CancellationToken token)
    {
      var resumes = await _repository.Resume
        .AsNoTracking()
        .Include(r => r.Job)
        .Include(r => r.Experience)
        .Include(r => r.PersonalInfo)
        .ToListAsync(token);

      return _mapper.Map<IEnumerable<ResumeDto>>(resumes);
    }

    public async Task<ResumeDto> GetResumeAsync(Guid resumeId, CancellationToken token)
    {
      var resume = await _repository.Resume
        .AsNoTracking()
        .Include(r => r.Job)
        .Include(r => r.Experience)
        .Include(r => r.PersonalInfo)
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

      await _jobInfoService.CreateDesiredJobAsync(resumeDTO);
      await _experienceService.CreateExperienceAsync(resumeDTO);
      await _personalInfoService.CreatePersonalInfoAsync(resumeDTO);

      return await GetResumeAsync(newResume.Id, default);
    }

    public async Task DeleteResumeAsync(Guid resumeId, CancellationToken token) 
    {
      var resumeForDelete = await GetResumeAsync(resumeId, token);
      await _s3.DeletePhotoAsync(resumeForDelete.PhotoId);
      _repository.Resume.Remove(_mapper.Map<Resume>(resumeForDelete));
      await _repository.SaveChangesAsync(token);
    }
  }
}
