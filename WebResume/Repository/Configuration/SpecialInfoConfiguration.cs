using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class SpecialInfoConfiguration : IEntityTypeConfiguration<SpecialInfo>
  {
    public void Configure(EntityTypeBuilder<SpecialInfo> builder)
    {
      builder.HasData
      (
        new SpecialInfo
        {
          Id = new Guid("F4B94A1A-AC14-420E-9C67-37EF9B46445F"),
          Title = "Suspicious activity",
          Description = "The client is acting suspiciously towards the service, " +
          "additional attention should be paid to their actions within the service."
        },
        new SpecialInfo
        {
          Id = new Guid("208C6DBC-77D1-4580-A5E8-3E972E2E1CB7"),
          Title = "Scammer",
          Description = "Takes advantage of the service's loyalty and exploits it to commit fraudulent or illegal actions, " +
          "resulting in financial losses for the service. It is not recommended to provide any services to the client."
        }
      );
    }
  }
}
