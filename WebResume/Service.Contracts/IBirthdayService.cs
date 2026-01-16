using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IBirthdayService
  {
    BirthdayListDto? GetBirthdayData();
  }
}
