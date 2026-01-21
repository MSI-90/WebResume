using AutoMapper;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
  public sealed class JobInfoService : IJobInfoService
  {
    private readonly ILogger _logger;
    private readonly RepositoryContext _context;
    private readonly IMapper _mapper;
    public JobInfoService(ILogger<JobInfoService> logger, RepositoryContext context, IMapper mapper)
    {
      _logger = logger;
      _context = context;
      _mapper = mapper;
    }

    public async Task<JobInfo?> GetJobInfoAsync(Guid? jobInfoGuid, CancellationToken token) => 
      await _context.JobInfos
        .AsNoTracking()
        .Where(j => j.Id.Equals(jobInfoGuid))
        .FirstOrDefaultAsync(token);

    public async Task CreateDesiredJobAsync(ResumeForCreationDTO resume)
    {
      if (CheckDesiredJobAsValid(resume)) return;

      var newJob = _mapper.Map<JobInfo>(resume.DesiredJob);
      newJob.Id = Guid.NewGuid();
      newJob = CheckAgreementData(newJob?.ByAgreement, newJob!);
      newJob.ResumeId = resume.ResumeId!.Value;
      await _context.JobInfos.AddAsync(newJob);
      await _context.SaveChangesAsync();
    }

    public bool CheckDesiredJobAsValid(ResumeForCreationDTO resume) 
    {
      return resume.DesiredJob is null;
    }

    public static JobInfo CheckAgreementData(bool? isAgreement, JobInfo newJob)
    {
      if (newJob is not null)
      {
        if (isAgreement is true)
        {
          newJob.DesiredSalary = null;
          newJob.Currency = null;
        }
      }

      return newJob!;
    }
  }
}
