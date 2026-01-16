namespace Shared.DataTransferObjects
{
  public record BirthdayListDto
  {
    public int[] Days { get; set; } = [];
    public BirthdayMonthDto[] Months { get; set; } = [];
    public int[] Years { get; set; } = [];
  }
}
