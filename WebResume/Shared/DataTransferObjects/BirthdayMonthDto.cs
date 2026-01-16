namespace Shared.DataTransferObjects
{
  public record BirthdayMonthDto
  {
    public string Name { get; set; } = string.Empty;
    public int Id { get; set; }
  }
}
