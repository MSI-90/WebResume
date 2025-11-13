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
    public ResumeService(RepositoryContext repository, ILoggerManager logger)
    {
      _repository = repository;
      _logger = logger;
    }

    public async Task<IEnumerable<ResumeDto>> GetResumeAsync(CancellationToken token)
    {
      try
      {
        var resumeDto = await _repository.Resume.Select(r => new ResumeDto(
        r.Id, string.Join(" ", r.LastName, r.FirstName, r.MiddleName), r.CreatedAt, r.UpdatedAt, r.TemplateId)).ToListAsync(token);
        return resumeDto;
      }
      catch (Exception ex) 
      {
        _logger.LogError($"Что-то пошло не так в методе {nameof(GetResumeAsync)}");
        throw;
      }
    }
      
  }
}
