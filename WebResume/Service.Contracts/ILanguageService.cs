using Entites.Models;
using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface ILanguageService
  {
    Task CreateLanguageInfoAsync(ResumeForCreationDto resume);
    bool CheckLanguageAsValid(ResumeForCreationDto resume);
    List<LanguageInfo> DeserializeLanguageExperience(ResumeForCreationDto resume);
  }
}
