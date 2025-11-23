using AutoMapper;
using Contracts;
using Entites.Models;
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

    public Task<ResumeDto> CreateDesiredJobAsync(JobInfoForCreationDto jobInfo)
    {
      throw new NotImplementedException();
    }
    //public async Task<ResumeDto> CreateDesiredJobAsync (JobInfoForCreationDto jobInfo)
    //{
    //  var newJobInfo = _mapper.Map<JobInfo>(jobInfo);
    //}
  }
}
