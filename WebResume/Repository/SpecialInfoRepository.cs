using Contracts;
using Entites.Models;

namespace Repository
{
  public class SpecialInfoRepository : RepositoryBase<SpecialInfo>, ISpecialInfoRepository
  {
    public SpecialInfoRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
  }
}
