using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class ExperienceConfiguration : IEntityTypeConfiguration<Experience>
  {
    public void Configure(EntityTypeBuilder<Experience> builder)
    {
      builder.ToTable("experience");
      builder.Property(e => e.JobTitle).HasColumnName("job_title").HasMaxLength(100);
      builder.Property(e => e.CompanyName).HasColumnName("company_name").HasMaxLength(200);
      builder.Property(e => e.JobResponsibilities).HasColumnName("job_responsibilites").HasMaxLength(10000);
      builder.Property(e => e.Achievements).HasColumnName("achivements").HasMaxLength(3000);
      builder.Property(e => e.StartJob).HasColumnName("start_job");
      builder.Property(e => e.EndJob).HasColumnName("end_job");
      builder.Property(e => e.ResumeId).HasColumnName("resume_id");
    }
  }
}
