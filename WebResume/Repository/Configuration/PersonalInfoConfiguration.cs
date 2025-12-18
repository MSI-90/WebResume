using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class PersonalInfoConfiguration : IEntityTypeConfiguration<PersonalInfo>
  {
    public void Configure(EntityTypeBuilder<PersonalInfo> builder)
    {
      builder.ToTable("personal_info");
      builder.Property(p => p.Id).HasColumnName("id");
      builder.Property(p => p.City).HasMaxLength(50).HasColumnName("city");
      builder.Property(p => p.IsDualCitizenship).HasColumnName("is_dual_citizenship");
      builder.Property(p => p.Birthday).HasColumnName("birthday");
      builder.Property(p => p.Sex).HasColumnName("sex");
      builder.Property(p => p.Moving).HasColumnName("moving");
      builder.Property(p => p.MaritalStatus).HasColumnName("maritalStatus");
      builder.Property(p => p.IsChildren).HasColumnName("is_children");
      builder.Property(p => p.ResumeId).HasColumnName("resume_id");
    }
  }
}
