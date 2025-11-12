using Contracts;
using Entites.Models;

namespace Repository
{
  public class ResumeRepository : RepositoryBase<Resume>, IResumeRepository
  {
    public ResumeRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
  }
}
