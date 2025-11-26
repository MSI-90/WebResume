using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class PhotoConfiguration : IEntityTypeConfiguration<Photo>
  {
    public void Configure(EntityTypeBuilder<Photo> builder)
    {
      builder.Property(p => p.IsDeleted).HasColumnName("is_deleted");
      builder.HasData
      (
        new Photo 
        {
          Id = new Guid("4041131F-CFD4-408A-8932-CE86CAD50DBA"),
          FileName = "filename",
          Length = 108485
        },
        new Photo
        {
          Id = new Guid("7CF4A689-7387-4F97-9939-49BECA8F68EA"),
          FileName = "1filename2",
          Length = 3413
        }
      );
    }
  }
}
