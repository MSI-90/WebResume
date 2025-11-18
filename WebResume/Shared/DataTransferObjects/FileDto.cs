namespace Shared.DataTransferObjects
{
  public record FileDto
  {
    public string? ContentType { get; init; }
    public long? Length { get; init; }
    public string? FileName { get; init; }
    public Stream? FileStream { get; init; }
  }
}
