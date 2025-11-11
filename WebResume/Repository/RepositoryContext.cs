using Microsoft.EntityFrameworkCore;
using Entites.Models;

namespace Repository
{
  public class RepositoryContext : DbContext
  {
    public DbSet<Resume> Resume {  get; set; }
    public DbSet<SpecialInfo> SpecialInfo { get; set; }
    public DbSet<Template> Templates { get; set; }
    public DbSet<User> Users { get; set; }
    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }

    
  }
}
