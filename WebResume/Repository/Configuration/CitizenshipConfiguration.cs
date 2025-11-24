using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class CitizenshipConfiguration : IEntityTypeConfiguration<Citizenship>
  {
    public void Configure(EntityTypeBuilder<Citizenship> builder)
    {
      builder.ToTable("citizenship");
      builder.Property(c => c.CountryName).IsRequired().HasColumnName("country_name");
    }
  }
}
