using AutoMapper;
using Entites.Exceptions;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
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
    private readonly IContactInfoService _contactInfoService;
    private readonly IEducationService _educationService;
    private readonly ICourseService _courseService;
    private readonly ILanguageInfoService _languageInfoService;
    private readonly IComputerSkillService _computerSkillService;
    private readonly IAdditionalInfoService _additionalInfoService;
    public ResumeService(RepositoryContext repository, 
      ILogger<ResumeService> logger, 
      IMapper mapper, 
      IPhotoService photoService, 
      IJobInfoService jobInfoService, 
      IExperienceService experienceService,
      IS3StorageService s3,
      IPersonalInfoService personalInfoService,
      IContactInfoService contactInfoService,
      IEducationService educationService,
      ICourseService courseService,
      ILanguageInfoService languageInfoService,
      IComputerSkillService computerSkillService,
      IAdditionalInfoService additionalInfoService)
    {
      _repository = repository;
      _logger = logger;
      _mapper = mapper;
      _jobInfoService = jobInfoService;
      _experienceService = experienceService;
      _s3 = s3;
      _personalInfoService = personalInfoService;
      _contactInfoService = contactInfoService;
      _educationService = educationService;
      _courseService = courseService;
      _languageInfoService = languageInfoService;
      _computerSkillService = computerSkillService;
      _additionalInfoService = additionalInfoService;
    }

    public async Task<IEnumerable<ResumeDto>> GetResumesAsync(CancellationToken token)
    {
      var resumes = await _repository.Resume
        .AsNoTracking()
        .Include(r => r.Job)
        .Include(r => r.Experience)
        .Include(r => r.PersonalInfo)
          .ThenInclude(p => p.Citizenships)
        .Include(r => r.ContactInfo)
        .Include(r => r.Education)
        .Include(r => r.Courses)
        .Include(r => r.Languages)
          .ThenInclude(l => l.Language)
        .Include(r => r.ComputerSkill)
        .Include(r => r.AdditionalInfo)
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
          .ThenInclude(p => p.Citizenships)
        .Include(r => r.ContactInfo)
        .Include(r => r.Education)
        .Include(r => r.Courses)
        .Include(r => r.Languages)
          .ThenInclude(l => l.Language)
        .Include(r => r.ComputerSkill)
        .Include(r => r.AdditionalInfo)
        .Where(r => r.Id.Equals(resumeId))
        .FirstOrDefaultAsync(token);

      return _mapper.Map<ResumeDto>(resume) ?? throw new ResumeNotFoundException(resumeId);
    }

    public async Task<ResumeDto> CreateResumeAsync(ResumeForCreationDTO resumeDTO)
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
      await _contactInfoService.CreateContactinfoAsync(resumeDTO);
      await _educationService.CreateEducationAsync(resumeDTO);
      await _courseService.CreateCourseAsync(resumeDTO);
      await _languageInfoService.CreateLanguageInfoAsync(resumeDTO);
      await _computerSkillService.CreateCSkillAsync(resumeDTO);
      await _additionalInfoService.CreateAdditionalInfoAsync(resumeDTO);

      return await GetResumeAsync(newResume.Id, default);
    }

    public async Task DeleteResumeAsync(Guid resumeId, CancellationToken token) 
    {
      var resumeForDelete = _repository.Resume.Where(r => r.Id.Equals(resumeId)).FirstOrDefault();
      if (resumeForDelete is null) return;
      await _s3.DeletePhotoAsync(resumeForDelete?.PhotoId);
      _repository.Resume.Remove(resumeForDelete!);
      await _repository.SaveChangesAsync(token);
    }
  }
}
