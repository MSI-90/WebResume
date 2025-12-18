using AutoMapper;
using Entites.Enums;
using Entites.Enums.Extends;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
  public sealed class LanguageService : ILanguageService
  {
    private readonly RepositoryContext _repository;
    private readonly IMapper _mapper;
    public LanguageService(RepositoryContext repository, IMapper mappe) 
    {
      _repository = repository;
      _mapper = mappe;
    }

    public async Task<IEnumerable<LanguageDto>> GetLanguages() => 
      _mapper.Map<IEnumerable<LanguageDto>>(
        await _repository.Languages.ToListAsync());

    public LanguageLevelDto GetLanguageLevel() => 
      new LanguageLevelDto
      {
        LevelEn = [..Enum.GetValues<LanguageLevel>().Select(l => l.ToString())],
        LevelRu = [..Enum.GetValues<LanguageLevel>().Select(l => l.GetDisplayName())]
      };

    public async Task<LanguageAndLevelDto> GetLanguageLevelAsync() => 
      new LanguageAndLevelDto
      {
        Languages = await GetLanguages(),
        Levels = GetLanguageLevel()
      };
  }
}
