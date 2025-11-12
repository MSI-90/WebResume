using Contracts;
using Entites.Models;

namespace Repository
{
  public class SpecialInfoRepository : RepositoryBase<SpecialInfo>, ISpecialInfo
  {
    public SpecialInfoRepository(RepositoryContext repositoryContext) : base(repositoryContext)
    {
    }
  }
}
