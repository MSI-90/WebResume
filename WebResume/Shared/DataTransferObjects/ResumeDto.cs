namespace Shared.DataTransferObjects
{
  public record ResumeDto(
    Guid Id, 
    string FIO,
    Guid? PhotoId,
    DateTime CreatedAt, 
    DateTime UpdatedAt, 
    Guid TemplateId)
  {
  }
}
