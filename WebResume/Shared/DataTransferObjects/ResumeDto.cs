namespace Shared.DataTransferObjects
{
  public record ResumeDto(
    Guid Id, 
    string FIO,
    PhotoDto? Photo,
    DesiredJobInfoOutputDto? DesiredJob,
    string? PurposeResume,
    DateTime CreatedAt, 
    DateTime UpdatedAt, 
    Guid TemplateId)
  {
  }
}
