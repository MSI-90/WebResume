using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class EducationConfiguration : IEntityTypeConfiguration<Education>
  {
    public void Configure(EntityTypeBuilder<Education> builder)
    {
      builder.ToTable("education");
      builder.Property(p => p.Id).HasColumnName("id");
      builder.Property(p => p.NameOfEducationalInstitution).HasColumnName("education_institution").HasMaxLength(200);
      builder.Property(p => p.Faculty).HasColumnName("faculty").HasMaxLength(100);
      builder.Property(p => p.Speciality).HasColumnName("speciality").HasMaxLength(100);
      builder.Property(p => p.Achievements).HasColumnName("achievements").HasMaxLength(4000);
      builder.Property(p => p.YearOfCompletion).HasColumnName("year_of_completion");
      builder.Property(p => p.EducationKind).HasColumnName("educationKind");
    }
  }
}
