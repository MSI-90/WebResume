using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class BufferConfiguration : IEntityTypeConfiguration<BufferEntity>
  {
    public void Configure(EntityTypeBuilder<BufferEntity> builder)
    {
      builder.ToTable("buffer");
      builder.Property(b => b.Id).HasColumnName("id");
      builder.Property(b => b.FileName).HasColumnName("file_name");
    }
  }
}
