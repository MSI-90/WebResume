using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IComputerSkillService
  {
    Task CreateCSkillAsync(ResumeForCreationDto resume);
    bool CheckCSkillsAsValid(ResumeForCreationDto resume);
    List<ComputerSkill> DeserializeComputerSkillExperience(ResumeForCreationDto resume);
  }
}
