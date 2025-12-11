using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class CInfoSocNetworkConfiguration : IEntityTypeConfiguration<CInfoSocNetwork>
  {
    public void Configure(EntityTypeBuilder<CInfoSocNetwork> builder)
    {
      builder.ToTable("contact_social");
      builder.HasKey(c => new { c.ContactInfoId, c.SocialNetworkId });
      builder.Property(c => c.ContactInfoId).HasColumnName("contact_info");
      builder.Property(c => c.SocialNetworkId).HasColumnName("social_network");
      builder.Property(c => c.LinkOnSocialNetwork).HasColumnName("social_link");
    }
  }
}
