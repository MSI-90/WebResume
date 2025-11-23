namespace Shared.DataTransferObjects
{
  public record ResumeDto(
    Guid Id, 
    string FIO,
    PhotoDto? Photo,
    DateTime CreatedAt, 
    DateTime UpdatedAt, 
    Guid TemplateId,
    Guid? JobId)
  {
  }
}
