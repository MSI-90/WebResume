using AutoMapper;
using Entites.Enums;
using Entites.Enums.Extends;
using Entites.Exceptions;
using Entites.Models;
using Microsoft.Extensions.Logging;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;
using System.Text.Json;

namespace Service
{
  public sealed class EducationService : IEducationService, IEducationCourse<EducationYearAndKindDto>
  {
    private readonly ILogger<EducationService> _logger;
    private readonly RepositoryContext _context;
    private readonly IMapper _mapper;
    public EducationService(ILogger<EducationService> logger, RepositoryContext context, IMapper mapper)
    {
      _logger = logger;
      _context = context;
      _mapper = mapper;
    }

    public async Task CreateEducationAsync(ResumeForCreationDto resume)
    {
      var newEducation = DeserialiseEducation(resume);
      await _context.Educations.AddRangeAsync(newEducation);
      await _context.SaveChangesAsync();
    }

    public bool CheckEducationAsValid(ResumeForCreationDto resume)
    {
      if (resume.Education is null || !resume.Education.Any())
        return false;

      return true;
    }

    public List<Education> DeserialiseEducation(ResumeForCreationDto resume)
    {
      if (!CheckEducationAsValid(resume))
        return new List<Education>();

      var newEducations = new List<Education>();
      foreach (var item in resume.Education!)
      {
        try
        {
          var educationItem = JsonSerializer.Deserialize<EducationForCreationDto>(item) ?? throw new EducationDeserializeException();
          var newEducation = _mapper.Map<Education>(educationItem);
          newEducation.Id = Guid.NewGuid();
          newEducation.ResumeId = resume.ResumeId!.Value;
          newEducations.Add(newEducation);
        }
        catch (JsonException jex)
        {
          _logger.LogWarning(jex.Message);
          throw new EducationDeserializeException();
        }
      }
      return newEducations;
    }

    public EducationYearAndKindDto? GetEducationYearAndKinds()
    {
      uint minYear = 1950, maxYear = 2050;
      var educationYearAndKind = new EducationYearAndKindDto();
      for (uint i = minYear; i <= maxYear; i++)
      {
        educationYearAndKind.YearOfCompleate.Add(i);
      }
      educationYearAndKind!.EducationKind = 
      [
        new EducationKindDto()
        {
          KindEn = [..Enum.GetValues<EducationKind>().Select(e => e.ToString())],
          KindRu = [..Enum.GetValues<EducationKind>().Select(e => e.GetDisplayName())]
        }
      ];

      return educationYearAndKind;
    }
  }
}
