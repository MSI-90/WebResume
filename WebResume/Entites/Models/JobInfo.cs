using Entites.Enums;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entites.Models
{
  public class JobInfo
  {
    public Guid? Id { get; set; }
    public string? JobTitle { get; set; }
    public decimal? DesiredSalary { get; set; }
    public Currency? Currency { get; set; }
    public bool ByAgreement { get; set; }
    public EmploymentType? EmploymentType { get; set; }
    public WorkSchedule? WorkSchedule { get; set; }


    [ForeignKey(nameof(Resume))]
    public Guid ResumeId { get; set; }
    public Resume? Resume { get; set; }
  }
}
