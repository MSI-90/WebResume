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
          FirstName = "Sergey",
          LastName = "Miller",
          MiddleName = "Ivanovich",
          JobTitle = "Specialist",
          CreatedAt = new DateTime(2025, 11, 12, 09, 43, 42, 361, DateTimeKind.Utc),
          UpdatedAt = new DateTime(2025, 11, 12, 23, 43, 42, 361, DateTimeKind.Utc),
          TemplateId = new Guid("DB58C76E-BCB5-4C6A-AD60-0E61BF3AC11C")
        },
        new Resume
        {
          Id = new Guid("CE078D47-3F43-423F-8C16-A039F805EE88"),
          FirstName = "John",
          LastName = "Doe",
          MiddleName = "middle",
          JobTitle = "Programmer",
          CreatedAt = new DateTime(2025, 11, 12, 10, 01, 42, 361, DateTimeKind.Utc),
          UpdatedAt = new DateTime(2025, 11, 12, 10, 01, 42, 361, DateTimeKind.Utc),
          TemplateId = new Guid("132805D2-3FC3-457C-86DE-40116433C062")
        }
      );
    }
  }
}
