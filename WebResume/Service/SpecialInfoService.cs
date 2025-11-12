using Contracts;
using Service.Contracts;

namespace Service
{
  public sealed class SpecialInfoService : ISpecialInfoService
  {
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    public SpecialInfoService(IRepositoryManager repository, ILoggerManager logger)
    {
      _repository = repository;
      _logger = logger;
    }
  }
}
