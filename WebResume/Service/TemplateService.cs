using Contracts;
using Repository;
using Service.Contracts;

namespace Service
{
  public sealed class TemplateService :ITemplateService
  {
    private readonly RepositoryContext _repository;
    private readonly ILoggerManager _logger;
    public TemplateService(RepositoryContext repository, ILoggerManager logger) 
    {
      _repository = repository;
      _logger = logger;
    }
  }
}
