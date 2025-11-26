using Contracts;
using Repository;
using Service.Contracts;

namespace Service
{
  public sealed class SpecialInfoService : ISpecialInfoService
  {
    private readonly RepositoryContext _repository;
    private readonly ILoggerManager _logger;
    public SpecialInfoService(RepositoryContext repository, ILoggerManager logger)
    {
      _repository = repository;
      _logger = logger;
    }
  }
}
