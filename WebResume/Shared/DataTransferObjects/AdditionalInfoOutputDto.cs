namespace Shared.DataTransferObjects
{
  public record AdditionalInfoOutputDto(
    Guid Id,
    bool MilitaryService, 
    bool DriverLicense,
    string? PersonalQualities,
    string? ProfessionalSkills,
    string? AboutYourself)
  {
  }
}
