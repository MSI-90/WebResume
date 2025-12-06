using Microsoft.Extensions.Logging;
using Repository;
using Service.Contracts;

namespace Service
{
  public sealed class SpecialInfoService : ISpecialInfoService
  {
    private readonly RepositoryContext _repository;
    private readonly ILogger _logger;
    public SpecialInfoService(RepositoryContext repository, ILogger<SpecialInfoService> logger)
    {
      _repository = repository;
      _logger = logger;
    }
  }
}
