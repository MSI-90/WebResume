using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class PortfolioConfiguration : IEntityTypeConfiguration<Portfolio>
  {
    public void Configure(EntityTypeBuilder<Portfolio> builder)
    {
      builder.ToTable("portfolio");
      builder.Property(p => p.Id).HasColumnName("id");
      builder.Property(p => p.Description).HasColumnName("description").HasMaxLength(4000);
      builder.Property(p => p.Url).HasColumnName("url").HasMaxLength(3000);
      builder.Property(p => p.ResumeId).HasColumnName("resume_id");
    }
  }
}
