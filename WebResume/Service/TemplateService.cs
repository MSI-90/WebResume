using Contracts;
using Service.Contracts;

namespace Service
{
  public sealed class TemplateService :ITemplateService
  {
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    public TemplateService(IRepositoryManager repository, ILoggerManager logger) 
    {
      _repository = repository;
      _logger = logger;
    }
  }
}
