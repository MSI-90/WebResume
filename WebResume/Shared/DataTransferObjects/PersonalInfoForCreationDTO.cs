using Entites.Enums;

namespace Shared.DataTransferObjects
{
  public record PersonalInfoForCreationDTO
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