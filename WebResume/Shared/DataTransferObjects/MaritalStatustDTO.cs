namespace Shared.DataTransferObjects
{
  public record MaritalStatustDTO
  {
    public byte Id { get; init; }
    public string StatusEn { get; init; } = string.Empty;
    public string StatusRu { get; init; } = string.Empty;
  }
}
