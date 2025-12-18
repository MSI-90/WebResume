using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface ILanguageService
  {
    Task<IEnumerable<LanguageDto>> GetLanguages();
    LanguageLevelDto GetLanguageLevel();
    Task<LanguageAndLevelDto> GetLanguageLevelAsync();
  }
}
