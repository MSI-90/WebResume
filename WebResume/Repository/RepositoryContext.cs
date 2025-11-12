using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;

namespace Repository
{
  public class RepositoryContext : DbContext
  {
    public DbSet<Resume> Resume {  get; set; }
    public DbSet<SpecialInfo> SpecialInfo { get; set; }
    public DbSet<Template> Templates { get; set; }
    //public DbSet<User> Users { get; set; }
    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfiguration(new ResumeConfiguration());
      modelBuilder.ApplyConfiguration(new TemplateConfiguration());
      modelBuilder.ApplyConfiguration(new SpecialInfoConfiguration());
    }
    
  }
}
