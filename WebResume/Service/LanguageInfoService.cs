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
  public sealed class LanguageInfoService : ILanguageInfoService
  {
    private readonly ILogger<LanguageInfoService> _logger;
    private readonly IMapper _mapper;
    private readonly RepositoryContext _context;
    public LanguageInfoService(ILogger<LanguageInfoService> logger, IMapper mapper, RepositoryContext context)
    {
      _logger = logger;
      _mapper = mapper;
      _context = context;
    }

    public async Task CreateLanguageInfoAsync(ResumeForCreationDTO resume)
    {
      if (!CheckLanguageAsValid(resume)) return;

      var newLanguage = new List<LanguageInfo>();
      foreach (var item in resume.Languages!)
      {
        var newLang = _mapper.Map<LanguageInfo>(item);
        newLang.Id = Guid.NewGuid();
        newLang.ResumeId = resume.ResumeId!.Value;
        newLanguage.Add(newLang);
      }

      await _context.LanguageInfos.AddRangeAsync(newLanguage);
      await _context.SaveChangesAsync();
    }

    public bool CheckLanguageAsValid(ResumeForCreationDTO resume) => 
      resume.Languages is not null && resume.Languages.Any();
  }
}
