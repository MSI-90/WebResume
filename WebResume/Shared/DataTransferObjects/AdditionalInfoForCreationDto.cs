namespace Shared.DataTransferObjects
{
  public record AdditionalInfoForCreationDto(
    bool MilitaryService, 
    bool DriverLicense, 
    string? PersonalQualities, 
    string? ProfessionalSkills, 
    string? AboutYourself)
  {
  }
}
