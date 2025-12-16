namespace Shared.DataTransferObjects
{
  public record CourseForCreationDto(
    string? CourseName,
    string? OrganizationTraining,
    uint YearOfCompletion,
    uint? DurationOfTraining,
    string? Achievements)
  {
  }
}
