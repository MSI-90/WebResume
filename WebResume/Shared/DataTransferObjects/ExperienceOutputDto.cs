namespace Shared.DataTransferObjects
{
  public record ExperienceOutputDto(
    Guid Id,
    string? JobTitle, 
    string? CompanyName, 
    string? JobResponsibilities,
    string? Achievements,
    DateOnly? StartJob,
    DateOnly? EndJob)
  {
  }
}
