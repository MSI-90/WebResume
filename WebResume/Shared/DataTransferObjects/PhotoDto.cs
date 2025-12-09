namespace Shared.DataTransferObjects
{
  public record PhotoDto(Guid Id, string? PresignedURL)
  {
  }
}
