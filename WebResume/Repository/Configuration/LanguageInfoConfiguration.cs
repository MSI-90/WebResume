using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class LanguageInfoConfiguration : IEntityTypeConfiguration<LanguageInfo>
  {
    public void Configure(EntityTypeBuilder<LanguageInfo> builder)
    {
      builder.ToTable("language_infos");
      builder.Property(li => li.Id).HasColumnName("id");
      builder.Property(li => li.Level).HasColumnName("level");
    }
  }
}
