using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class JobInfoConfiguration : IEntityTypeConfiguration<JobInfo>
  {
    public void Configure(EntityTypeBuilder<JobInfo> builder)
    {
      builder.ToTable("job_info");
      builder.Property(j => j.Id).HasColumnName("id");
      builder.Property(j => j.JobTitle).HasMaxLength(200).HasColumnName("job_title");
      builder.Property(j => j.DesiredSalary).HasColumnType("decimal").HasColumnName("desired_salary");
      builder.Property(j => j.Currency).HasColumnName("currency");
      builder.Property(j => j.ByAgreement).HasColumnName("agreement");
      builder.Property(j => j.EmploymentType).HasColumnName("employment_type");
      builder.Property(j => j.WorkSchedule).HasColumnName("work_shedule");
      builder.Property(j => j.ResumeId).HasColumnName("resume_id");
    }
  }
}
