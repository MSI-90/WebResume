using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Repository.Configuration;
using System.Reflection;

namespace Repository
{
  public class RepositoryContext : DbContext
  {
    public DbSet<Resume> Resume {  get; set; }
    public DbSet<SpecialInfo> SpecialInfo { get; set; }
    public DbSet<Template> Templates { get; set; }
    public DbSet<JobInfo> JobInfos { get; set; }
    public DbSet<PersonalInfo> PersonalInfos { get; set; }
    public DbSet<Citizenship> Citizenships { get; set; }
    public DbSet<ResumeCitizenship> ResumeCitizenships { get; set; }
    public DbSet<BufferEntity> BufferInfo { get; set; }
    public DbSet<Experience> Experience { get; set; }
    //public DbSet<User> Users { get; set; }
    public RepositoryContext(DbContextOptions options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
      modelBuilder.ApplyConfigurationsFromAssembly(
        Assembly.GetExecutingAssembly());
    }
    
  }
}
