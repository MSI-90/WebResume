namespace Shared.DataTransferObjects
{
  public record ResumeDto(
    Guid Id, 
    string FIO,
    PhotoDto? Photo,
    DesiredJobInfoOutputDto? DesiredJob,
    IEnumerable<ExperienceOutputDto?> Experience,
    string? PurposeResume,
    DateTime CreatedAt, 
    DateTime UpdatedAt, 
    Guid TemplateId)
  {
  }
}
