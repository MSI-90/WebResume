using Contracts;
using Service.Contracts;

namespace Service
{
  internal sealed class ResumeService : IResumeService
  {
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    public ResumeService(IRepositoryManager repository, ILoggerManager logger)
    {
      _repository = repository;
      _logger = logger;
    }
  }
}
