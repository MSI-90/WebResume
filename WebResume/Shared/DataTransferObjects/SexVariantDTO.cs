namespace Shared.DataTransferObjects
{
  public record SexVariantDTO
  {
    public byte Id { get; init; }
    public string SexEn { get; init; } = string.Empty;
    public string SexRu { get; init; } = string.Empty;
  }
}
