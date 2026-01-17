using Entites.Enums;

namespace Shared.DataTransferObjects
{
  public record PersonalInfoDTO
  ( 
    string? City, 
    bool IsDualCitizenship,
    List<CitizenshipOutputDto> Citizenships,
    DateOnly Birthday, 
    bool IsChildren, 
    Sex Sex, 
    Moving Moving, 
    MaritalStatus MaritalStatus
  ) 
  { 
  }
}
