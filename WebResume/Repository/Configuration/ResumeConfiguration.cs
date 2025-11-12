
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class ResumeConfiguration : IEntityTypeConfiguration<Resume>
  {
    public void Configure(EntityTypeBuilder<Resume> builder)
    {
      builder.HasData
      (
        new Resume
        {
          Id = new Guid("7B8B80FB-1C94-4E46-A069-EE51901B3D3E"),
          //FIO = "Миллер Сергей Иванович",

        }
      );
    }
  }
}
