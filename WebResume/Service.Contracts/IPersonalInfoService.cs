using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IPersonalInfoService
  {
    Task CreatePersonalInfoAsync(ResumeForCreationDto resumeDto);
    bool CheckPInfoAsValid(ResumeForCreationDto resumeDto);
    PersonalInfoDTO? DeserializePInfo(ResumeForCreationDto resumeDto);
    IEnumerable<MovingVariantDTO> MovingVariants();
    IEnumerable<SexVariantDTO> SexVariant();
    IEnumerable<MaritalStatustDTO> MaritalStatusVariants();
  }
}
