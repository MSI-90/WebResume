using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IPersonalInfoService
  {
    Task CreatePersonalInfoAsync(ResumeForCreationDTO resumeDto);
    bool CheckPInfoAsValid(ResumeForCreationDTO resumeDto);
    IEnumerable<MovingVariantDTO> MovingVariants();
    IEnumerable<SexVariantDTO> SexVariant();
    IEnumerable<MaritalStatustDTO> MaritalStatusVariants();
  }
}
