using Entites.Enums;

namespace Shared.DataTransferObjects
{
  public record PersonalInfoDTO
  (
    string? City,
    bool IsDualCitizenship,
    IEnumerable<CitizenshipOutputDto> Citizenships,
    DateOnly Birthday,
    bool IsChildren,
    Sex Sex,
    Moving Moving,
    MaritalStatus MaritalStatus
  )
  {
  }
}