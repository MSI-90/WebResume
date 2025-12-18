using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class ComputerSkillConfiguration : IEntityTypeConfiguration<ComputerSkill>
  {
    public void Configure(EntityTypeBuilder<ComputerSkill> builder)
    {
      builder.ToTable("computer_skill");
      builder.Property(c => c.Id).HasColumnName("id");
      builder.Property(c => c.Title).HasColumnName("title").HasMaxLength(250);
    }
  }
}
