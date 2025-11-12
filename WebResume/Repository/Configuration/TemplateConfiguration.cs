using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class TemplateConfiguration : IEntityTypeConfiguration<Template>
  {
    public void Configure(EntityTypeBuilder<Template> builder)
    {
      builder.HasData
      (
        new Template
        {
          TemplateId = new Guid("DB58C76E-BCB5-4C6A-AD60-0E61BF3AC11C"),
          Name = "Default template",
          TemplateKind = Entites.Enums.TemplateKind.Free
        },
        new Template
        {
          TemplateId = new Guid("132805D2-3FC3-457C-86DE-40116433C062"),
          Name = "Premium template",
          TemplateKind = Entites.Enums.TemplateKind.Premium
        }
      );
    }
  }
}
