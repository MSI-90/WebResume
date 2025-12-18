using AutoMapper;
using Entites.Exceptions;
using Entites.Models;
using Microsoft.Extensions.Logging;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;
using System.Text.Json;

namespace Service
{
  public sealed class LanguageService : ILanguageService
  {
    private readonly ILogger<ILanguageService> _logger;
    private readonly IMapper _mapper;
    private readonly RepositoryContext _context;
    public LanguageService(ILogger<ILanguageService> logger, IMapper mapper, RepositoryContext context)
    {
      _logger = logger;
      _mapper = mapper;
      _context = context;
    }

    public async Task CreateLanguageInfoAsync(ResumeForCreationDto resume)
    {
      var newLanguages = DeserializeLanguageExperience(resume);
      await _context.LanguageInfos.AddRangeAsync(newLanguages);
      await _context.SaveChangesAsync();
    }

    public bool CheckLanguageAsValid(ResumeForCreationDto resume)
    {
      return resume.Languages is not null || resume.Languages.Any();
    }

    public List<LanguageInfo> DeserializeLanguageExperience(ResumeForCreationDto resume)
    {
      if (!CheckLanguageAsValid(resume))
        return new List<LanguageInfo>();

      var newLanguage = new List<LanguageInfo>();
      foreach (var item in resume.Languages!)
      {
        try
        {
          var languageItem = JsonSerializer.Deserialize<LanguageForCreationDto>(item) ?? throw new LanguageInfoDeserializeException();
          var newLang = _mapper.Map<LanguageInfo>(languageItem);
          newLang.Id = Guid.NewGuid();
          newLang.ResumeId = resume.ResumeId!.Value;
          newLanguage.Add(newLang);
        }
        catch (JsonException jex)
        {
          _logger.LogWarning(jex.Message);
          throw new LanguageInfoDeserializeException();
        }
      }
      return newLanguage;
    }
  }
}
