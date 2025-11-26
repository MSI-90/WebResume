using AutoMapper;
using Contracts;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;
using System.Text.Json;

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

    public async Task<JobInfo?> CreateDesiredJobAsync(Guid? resumeId, string? jobInfo)
    {
      if (string.IsNullOrEmpty(jobInfo))
        return null;

      DesiredJobInfoForCreationDto? desiredJob;
      try
      {
        desiredJob = JsonSerializer.Deserialize<DesiredJobInfoForCreationDto>(jobInfo);
        if (desiredJob == null)
          throw new Exception("DesiredJob is null after JSON deserialize");
      }
      catch (Exception ex)
      {
        _loggerManager.LogError(ex.Message);
        throw;
      }

      var newJob = _mapper.Map<JobInfo>(desiredJob);
      newJob.Id = Guid.NewGuid();
      newJob = CheckAgreementData(desiredJob?.ByAgreement, newJob);
      newJob.ResumeId = resumeId!.Value;
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
