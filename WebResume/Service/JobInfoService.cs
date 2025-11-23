using AutoMapper;
using Contracts;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
  public sealed class JobInfoService : IJobInfoService
  {
    private readonly ILoggerManager _loggerManager;
    private readonly RepositoryContext _context;
    private readonly IMapper _mapper;
    public JobInfoService(ILoggerManager loggerManager, RepositoryContext context, IMapper mapper)
    {
      _loggerManager = loggerManager;
      _context = context;
      _mapper = mapper;
    }

    public async Task<JobInfo?> GetJobInfoAsync(Guid? jobInfoGuid, CancellationToken token) => 
      await _context.JobInfos
        .AsNoTracking()
        .Where(j => j.Id.Equals(jobInfoGuid))
        .FirstOrDefaultAsync(token);

    public async Task<JobInfo?> CreateDesiredJobAsync(DesiredJobInfoForCreationDto? jobInfo)
    {
      var newJob = _mapper.Map<JobInfo>(jobInfo);
      newJob.Id = Guid.NewGuid();
      newJob = CheckAgreementData(jobInfo?.ByAgreement, newJob);
      newJob.ResumeId = jobInfo!.ResumeId;
      _context.JobInfos.Add(newJob);
      await _context.SaveChangesAsync();

      return await GetJobInfoAsync(newJob.Id, default);
    }

    public static JobInfo CheckAgreementData(bool? isAgreement, JobInfo newJob)
    {
      if (newJob is not null)
      {
        if (isAgreement == true)
        {
          newJob.DesiredSalary = null;
          newJob.Currency = null;
        }
      }

      return newJob!;
    }
  }
}
