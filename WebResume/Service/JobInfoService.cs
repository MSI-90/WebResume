using AutoMapper;
using Entites.Exceptions;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;
using System.Security.AccessControl;
using System.Text.Json;

namespace Service
{
  public sealed class JobInfoService : IJobInfoService
  {
    private readonly ILogger _loggerManager;
    private readonly RepositoryContext _context;
    private readonly IMapper _mapper;
    public JobInfoService(ILogger<JobInfoService> logger, RepositoryContext context, IMapper mapper)
    {
      _loggerManager = logger;
      _context = context;
      _mapper = mapper;
    }

    public async Task<JobInfo?> GetJobInfoAsync(Guid? jobInfoGuid, CancellationToken token) => 
      await _context.JobInfos
        .AsNoTracking()
        .Where(j => j.Id.Equals(jobInfoGuid))
        .FirstOrDefaultAsync(token);

    public async Task CreateDesiredJobAsync(ResumeForCreationDto resume)
    {
      var desiredJob = DeserilizeDesiredJob(resume);
      if (desiredJob is null)
        return;

      var newJob = _mapper.Map<JobInfo>(desiredJob);
      newJob.Id = Guid.NewGuid();
      newJob = CheckAgreementData(desiredJob?.ByAgreement, newJob);
      newJob.ResumeId = resume.ResumeId!.Value;
      await _context.JobInfos.AddAsync(newJob);
      await _context.SaveChangesAsync();
    }

    public bool CheckDesiredJobAsValid(ResumeForCreationDto resume) 
    {
      if (string.IsNullOrEmpty(resume.DesiredJob) || string.IsNullOrWhiteSpace(resume.DesiredJob))
        return false;

      return true;
    }

    public DesiredJobInfoForCreationDto? DeserilizeDesiredJob(ResumeForCreationDto resume) 
    {
      if (!CheckDesiredJobAsValid(resume))
        return null;

      try
      {
        return JsonSerializer.Deserialize<DesiredJobInfoForCreationDto>(resume.DesiredJob!) ?? throw new DesiredJobInfoDeserializeException();
      }
      catch (JsonException jex)
      {
        _loggerManager.LogWarning(jex.Message);
        throw new DesiredJobInfoDeserializeException();
      }
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
