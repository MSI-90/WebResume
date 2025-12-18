using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class CoursesConfiguration : IEntityTypeConfiguration<Course>
  {
    public void Configure(EntityTypeBuilder<Course> builder)
    {
      builder.ToTable("courses");
      builder.Property(p => p.Id).HasColumnName("id");
      builder.Property(p => p.CourseName).HasColumnName("course_name").HasMaxLength(500);
      builder.Property(p => p.OrganizationTraining).HasColumnName("organization_training").HasMaxLength(500);
      builder.Property(p => p.DurationOfTraining).HasColumnName("duration_of_training").HasMaxLength(300);
      builder.Property(p => p.Achievements).HasColumnName("achievements").HasMaxLength(4000);
      builder.Property(p => p.ResumeId).HasColumnName("resume_id");
    }
  }
}
