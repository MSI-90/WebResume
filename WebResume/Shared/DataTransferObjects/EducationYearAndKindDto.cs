using Entites.Enums;

namespace Shared.DataTransferObjects
{
  public record EducationYearAndKindDto()
  {
    public List<uint> YearOfCompleate { get; set; } = [];
    public List<EducationKindDto> EducationKind { get; set; } = [];
  }
}
