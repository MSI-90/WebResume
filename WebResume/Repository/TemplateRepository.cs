using Contracts;
using Entites.Models;

namespace Repository
{
  public class TemplateRepository : RepositoryBase<Template>, ITemplate
  {
    public TemplateRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
  }
}
