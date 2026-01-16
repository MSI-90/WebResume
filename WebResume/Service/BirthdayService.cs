using Entites.Enums;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
  public sealed class BirthdayService : IBirthdayService
  {
    private readonly string[] _birthdays;
    public BirthdayService()
    {
      _birthdays = ["Январь", "Февраль", "Март", "Апрель", "Май", "Июнь", "Июль", "Август", "Сентябрь", "Октябрь", "Ноябрь", "Декабрь"];
    }
    public BirthdayListDto? GetBirthdayData()
    {
      int minYear = 1950, maxYear = DateTime.Now.Year;
      var birthdayList = new BirthdayListDto();

      return new BirthdayListDto
      {
        Days = Enumerable.Range(1, 31).ToArray(),

        Months = _birthdays.Select((name, index) => new BirthdayMonthDto
        {
           Name = name,
           Id = index + 1
         }).ToArray(),

          Years = Enumerable
       .Range(minYear, maxYear - minYear + 1)
       .ToArray()
      };
    }
  }
}
