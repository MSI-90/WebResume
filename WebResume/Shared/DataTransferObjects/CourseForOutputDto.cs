namespace Shared.DataTransferObjects
{
  public record CourseForOutputDto(
    Guid Id,
    string? CourseName,
    string? OrganizationTraining,
    uint YearOfCompletion,
    uint? DurationOfTraining,
    string? Achievements)
  {
  }
}
