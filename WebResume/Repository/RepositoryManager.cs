using Contracts;

namespace Repository
{
  public sealed class RepositoryManager : IRepositoryManager
  {
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<IResumeRepository> _resumeRepository;
    private readonly Lazy<ITemplateRepository> _templateRepository;
    private readonly Lazy<ISpecialInfoRepository> _specialInfoRepository;
    public RepositoryManager(RepositoryContext repositoryContext)
    {
      _repositoryContext = repositoryContext;
      _resumeRepository = new Lazy<IResumeRepository>(() => new ResumeRepository(_repositoryContext));
      _templateRepository = new Lazy<ITemplateRepository>(() => new TemplateRepository(_repositoryContext));
      _specialInfoRepository = new Lazy<ISpecialInfoRepository>(() => new SpecialInfoRepository(_repositoryContext));
    }

    public IResumeRepository Resume => _resumeRepository.Value;
    public ITemplateRepository Template => _templateRepository.Value;
    public ISpecialInfoRepository SpecialInfo => _specialInfoRepository.Value;
    public void Save() => _repositoryContext.SaveChanges();
  }
}
