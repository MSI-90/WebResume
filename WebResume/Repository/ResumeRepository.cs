using Contracts;
using Entites.Models;

namespace Repository
{
  public class ResumeRepository : RepositoryBase<Resume>, IResume
  {
    public ResumeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
  }
}
