using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class SocialNetworkConfiguration : IEntityTypeConfiguration<SocialNetwork>
  {
    public void Configure(EntityTypeBuilder<SocialNetwork> builder)
    {
      builder.ToTable("social_network");
      builder.Property(s => s.Id).HasColumnName("id");
      builder.Property(s => s.Name).HasColumnName("name");
      builder.Property(s => s.IconUrl).HasColumnName("icon");
    }
  }
}
