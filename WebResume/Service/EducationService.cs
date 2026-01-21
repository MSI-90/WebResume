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

    public async Task CreateEducationAsync(ResumeForCreationDTO resume)
    {
      if (!CheckEducationAsValid(resume)) return;

      var newEducations = new List<Education>();
      foreach (var item in resume.Education!)
      {

        var newEducation = _mapper.Map<Education>(item);
        newEducation.Id = Guid.NewGuid();
        newEducation.ResumeId = resume.ResumeId!.Value;
        newEducations.Add(newEducation);
      }

      await _context.Educations.AddRangeAsync(newEducations);
      await _context.SaveChangesAsync();
    }

    public bool CheckEducationAsValid(ResumeForCreationDTO resume) => 
      resume.Education is not null && resume.Education.Any();

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
