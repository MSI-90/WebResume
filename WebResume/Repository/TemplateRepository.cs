using Contracts;
using Entites.Models;

namespace Repository
{
  public class TemplateRepository : RepositoryBase<Template>, ITemplateRepository
  {
    public TemplateRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
  }
}
