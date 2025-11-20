namespace Shared.DataTransferObjects
{
  public record PhotoToUpload (string? FileName, Guid? PhotoId, string? FilePath)
  {
  }
}
