using Entites.Enums;

namespace Shared.DataTransferObjects
{
  public record DesiredJobInfoForManipulationDto
  {
    public string? JobTitle { get; init; }
    public decimal? DesiredSalary { get; init; }
    public Currency? Currency { get; init; }
    public bool ByAgreement { get; init; }
    public EmploymentType? EmploymentType { get; init; }
    public WorkSchedule? WorkSchedule { get; init; }
    public Guid ResumeId { get; set; }
  }
}
