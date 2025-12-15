
using Entites.Enums;

namespace Shared.DataTransferObjects
{
  public record EducationOutputDto(
    Guid Id,
    string NameOfEducationalInstitution,
    string? Faculty,
    string Speciality,
    string? Achievements,
    uint YearOfCompletion,
    EducationKind EducationKind)
  {
  }
}
