using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class ContactInfoConfiguration : IEntityTypeConfiguration<ContactInfo>
  {
    public void Configure(EntityTypeBuilder<ContactInfo> builder)
    {
      builder.ToTable("contact_info");
      builder.Property(p => p.Id).HasColumnName("id");
      builder.Property(p => p.Phone).HasColumnName("phone");
      builder.Property(p => p.Email).HasColumnName("email");
      builder.Property(p => p.ResumeId).HasColumnName("resume_id");
      builder.Property(p => p.SocialNetwork).HasColumnName("social_network").HasColumnType("jsonb");
    }
  }
}
