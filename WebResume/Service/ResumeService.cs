using AutoMapper;
using Contracts;
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
    public ResumeService(RepositoryContext repository, ILoggerManager logger, IMapper mapper)
    {
      _repository = repository;
      _logger = logger;
      _mapper = mapper;
    }

    public async Task<IEnumerable<ResumeDto>> GetResumesAsync(CancellationToken token)
    {
      var resumes = await _repository.Resume.ToListAsync(token);
      var resumeDto = _mapper.Map<IEnumerable<ResumeDto>>(resumes);
      return resumeDto;
    }

    public async Task<ResumeDto> GetResumeAsync(Guid resumeId, CancellationToken token)
    {
      var resume = await _repository.Resume.Where(r => r.Id.Equals(resumeId)).FirstOrDefaultAsync(token);
      //if (resume is null)
      //  throw new ResumeNotFoundException();

      return _mapper.Map<ResumeDto>(resume);
    }
      
  }
}
