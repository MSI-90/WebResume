using Entites.Models;

namespace Shared.DataTransferObjects
{
  public record ResumeDto(
    Guid Id, 
    string FIO,
    Guid? PhotoId,
    PersonalInfoDto? PersonalInfo,
    DesiredJobInfoOutputDto? DesiredJob,
    ContactInfoOutputDto ContactInfo,
    IEnumerable<ExperienceOutputDto?> Experience,
    string? PurposeResume,
    DateTime CreatedAt, 
    DateTime UpdatedAt, 
    Guid TemplateId)
  {
  }
}
