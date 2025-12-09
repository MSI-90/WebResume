using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class PInfoCitizenshipConfiguration : IEntityTypeConfiguration<PersonalInfoCitizenship>
  {
    public void Configure(EntityTypeBuilder<PersonalInfoCitizenship> builder)
    {
      builder.ToTable("resume_citizenship");
      builder.Property(pc => pc.PersonalInfoId).HasColumnName("resume_id");
      builder.Property(pc => pc.CitizenshipsId).HasColumnName("citizenship_id");

      builder.HasKey(pc => new { pc.PersonalInfoId, pc.CitizenshipsId });

      builder.HasOne(pc => pc.PInfo)
             .WithMany(p => p.Citizenships)
             .HasForeignKey(pc => pc.PersonalInfoId);

      builder.HasOne(pc => pc.Citizenship)
             .WithMany(c => c.PersonalInfos)
             .HasForeignKey(pc => pc.CitizenshipsId);
    }
  }
}
