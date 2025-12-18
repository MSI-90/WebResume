namespace Shared.DataTransferObjects
{
  public record ResumeDto(
    Guid Id, 
    string FIO,
    Guid? PhotoId,
    PersonalInfoDto? PersonalInfo,
    DesiredJobInfoOutputDto? DesiredJob,
    ContactInfoOutputDto ContactInfo,
    IEnumerable<EducationOutputDto?> Education,
    IEnumerable<CourseForOutputDto>? Course,
    IEnumerable<ExperienceOutputDto?> Experience,
    IEnumerable<LanguageInfoOutputDto>? Languages,
    string? PurposeResume,
    DateTime CreatedAt, 
    DateTime UpdatedAt, 
    Guid TemplateId)
  {
  }
}
