using Entites.Enums;

namespace Shared.DataTransferObjects
{
  public record EducationForCreationDto(
    string NameOfEducationalInstitution, 
    string? Faculty, 
    string Speciality, 
    string? Achievements, 
    uint YearOfCompletion,
    EducationKind EducationKind)
  {
  }
}
