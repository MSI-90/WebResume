using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface ILanguageInfoService
  {
    Task CreateLanguageInfoAsync(ResumeForCreationDTO resume);
    bool CheckLanguageAsValid(ResumeForCreationDTO resume);
  }
}
