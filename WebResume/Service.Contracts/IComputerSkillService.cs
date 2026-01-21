using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface IComputerSkillService
  {
    Task CreateCSkillAsync(ResumeForCreationDTO resume);
    bool CheckCSkillsAsValid(ResumeForCreationDTO resume);
  }
}
