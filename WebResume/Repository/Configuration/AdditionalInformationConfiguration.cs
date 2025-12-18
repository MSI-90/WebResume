using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class AdditionalInformationConfiguration : IEntityTypeConfiguration<AdditionalInformation>
  {
    public void Configure(EntityTypeBuilder<AdditionalInformation> builder)
    {
      builder.ToTable("additional_information");
      builder.Property(builder => builder.Id).HasColumnName("id");
      builder.Property(builder => builder.MilitaryService).HasColumnName("military_service");
      builder.Property(builder => builder.DriverLicense).HasColumnName("driver_license");
      builder.Property(builder => builder.PersonalQualities).HasColumnName("personal_qualities").HasMaxLength(4000);
      builder.Property(builder => builder.ProfessionalSkills).HasColumnName("professional_skills").HasMaxLength(4000);
      builder.Property(builder => builder.AboutYourself).HasColumnName("about_yourself").HasMaxLength(4000);
      builder.Property(builder => builder.ResumeId).HasColumnName("resume_id");
    }
  }
}
