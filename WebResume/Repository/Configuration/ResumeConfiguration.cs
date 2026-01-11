using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Configuration
{
  public class ResumeConfiguration : IEntityTypeConfiguration<Resume>
  {
    public void Configure(EntityTypeBuilder<Resume> builder)
    {
      builder
        .HasOne(r => r.Job)
        .WithOne(j => j.Resume)
        .HasForeignKey<JobInfo>(j => j.ResumeId)
        .IsRequired()
        .OnDelete(DeleteBehavior.Cascade);

      builder
        .HasOne(r => r.PersonalInfo)
        .WithOne(j => j.Resume)
        .HasForeignKey<PersonalInfo>(p => p.ResumeId)
        .IsRequired()
        .OnDelete(DeleteBehavior.Cascade);

      builder.HasOne(r => r.ContactInfo)
        .WithOne(c => c.Resume)
        .HasForeignKey<ContactInfo>(c => c.ResumeId)
        .IsRequired()
        .OnDelete(DeleteBehavior.Cascade);

      builder.HasOne(r => r.AdditionalInfo)
        .WithOne(a => a.Resume)
        .HasForeignKey<AdditionalInformation>(a => a.ResumeId)
        .IsRequired()
        .OnDelete(DeleteBehavior.Cascade);

      builder
        .HasOne(r => r.Template)
        .WithMany(t => t.Resumes)
        .HasForeignKey(r => r.TemplateId)
        .OnDelete(DeleteBehavior.Restrict);

      builder.ToTable("resume");
      builder.Property(r => r.Id).HasColumnName("resume_id");
      builder.Property(r => r.FirstName).HasColumnName("first_name").HasMaxLength(50);
      builder.Property(r => r.LastName).HasColumnName("last_name").HasMaxLength(70);
      builder.Property(r => r.FatherName).HasColumnName("middle_name").HasMaxLength(70);
      builder.Property(r => r.PurposeResume).HasColumnName("purpose_resume").HasMaxLength(500);
      builder.Property(r => r.CreatedAt).HasColumnName("created_at");
      builder.Property(r => r.UpdatedAt).HasColumnName("update_at");
      builder.Property(r => r.TemplateId).HasColumnName("template_id");

      builder.HasData
      (
        new Resume
        {
          Id = new Guid("7B8B80FB-1C94-4E46-A069-EE51901B3D3E"),
          FirstName = "Sergey",
          LastName = "Miller",
          FatherName = "Ivanovich",
          CreatedAt = new DateTime(2025, 11, 12, 09, 43, 42, 361, DateTimeKind.Utc),
          UpdatedAt = new DateTime(2025, 11, 12, 23, 43, 42, 361, DateTimeKind.Utc),
          TemplateId = new Guid("DB58C76E-BCB5-4C6A-AD60-0E61BF3AC11C")
        },
        new Resume
        {
          Id = new Guid("CE078D47-3F43-423F-8C16-A039F805EE88"),
          FirstName = "John",
          LastName = "Doe",
          FatherName = "middle",
          CreatedAt = new DateTime(2025, 11, 12, 10, 01, 42, 361, DateTimeKind.Utc),
          UpdatedAt = new DateTime(2025, 11, 12, 10, 01, 42, 361, DateTimeKind.Utc),
          TemplateId = new Guid("132805D2-3FC3-457C-86DE-40116433C062")
        }
      );
    }
  }
}
