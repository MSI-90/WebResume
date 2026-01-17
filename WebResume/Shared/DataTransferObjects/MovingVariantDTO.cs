namespace Shared.DataTransferObjects
{
  public record MovingVariantDTO
  {
    public byte Id { get; init; }
    public string VariantEn { get; init; } = string.Empty;
    public string VariantRu { get; init; } = string.Empty;
  }
}
