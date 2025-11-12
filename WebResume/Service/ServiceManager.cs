using Contracts;
using Service.Contracts;

namespace Service
{
  public sealed class ServiceManager : IServiceManager
  {
    private readonly Lazy<IResumeService> _resumeService;
    private readonly Lazy<ITemplateService> _templateService;
    private readonly Lazy<ISpecialInfoService> _specialInfoService;
    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
    {
      _resumeService = new Lazy<IResumeService>(() => new ResumeService(repositoryManager, logger));
      _templateService = new Lazy<ITemplateService>(() => new TemplateService(repositoryManager, logger));
      _specialInfoService = new Lazy<ISpecialInfoService>(() => new SpecialInfoService(repositoryManager, logger));
    }
    public IResumeService ResumeService => _resumeService.Value;

    public ITemplateService TemplateService => _templateService.Value;

    public ISpecialInfoService SpecialInfoService => _specialInfoService.Value;
  }
}
