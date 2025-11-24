using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class ResumeCitizenshipConfiguration : IEntityTypeConfiguration<ResumeCitizenship>
  {
    public void Configure(EntityTypeBuilder<ResumeCitizenship> builder)
    {
      builder.ToTable("resume_citizenship");
      builder.Property(rc => rc.ResumesId).HasColumnName("resume_id");
      builder.Property(rc => rc.CitizenshipsId).HasColumnName("citizenship_id");

      builder.HasKey(rc => new { rc.ResumesId, rc.CitizenshipsId });

      builder.HasOne(rc => rc.Resume)
             .WithMany(r => r.ResumeCitizenship)
             .HasForeignKey(rc => rc.ResumesId);

      builder.HasOne(rc => rc.Citizenship)
             .WithMany(c => c.ResumesCitizenship)
             .HasForeignKey(rc => rc.CitizenshipsId);
    }
  }
}
