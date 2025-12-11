using AutoMapper;
using Entites.Exceptions;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;
using System.Text.Json;

namespace Service
{
  public sealed class ExperienceService : IExperienceService
  {
    private readonly RepositoryContext _context;
    private readonly ILogger _logger;
    private readonly IMapper _mapper;
    public ExperienceService(RepositoryContext context, ILogger<ExperienceService> logger, IMapper mapper) 
    {
      _context = context;
      _logger = logger;
      _mapper = mapper;
    }
    public async Task<IEnumerable<Experience?>> GetExperienceAsync(Guid resumeId, CancellationToken token) => 
      await _context.Experience
      .Where(e => e.ResumeId.Equals(resumeId))
      .ToListAsync(token);
    
    public async Task CreateExperienceAsync(ResumeForCreationDto resume)
    {
      var newExperiences = DeserialiseExperience(resume);
      await _context.Experience.AddRangeAsync(newExperiences);
      await _context.SaveChangesAsync();
    }

    public bool CheckExperienceAsValid(ResumeForCreationDto resume)
    {
      if (resume.Experience is null || !resume.Experience.Any())
        return false;
      
      return true;
    }

    public List<Experience> DeserialiseExperience(ResumeForCreationDto resume) 
    {
      if (!CheckExperienceAsValid(resume))
        return new List<Experience>();

      var newExperiences = new List<Experience>();
      foreach (var item in resume.Experience!)
      {
        try
        {
          var experienceItem = JsonSerializer.Deserialize<ExperienceForCreationDto>(item) ?? throw new ExperienceDeserializeException();
          var newExp = _mapper.Map<Experience>(experienceItem);
          newExp.Id = Guid.NewGuid();
          newExp.ResumeId = resume.ResumeId!.Value;
          newExperiences.Add(newExp);
        }
        catch (JsonException jex)
        {
          _logger.LogWarning(jex.Message);
          throw new ExperienceDeserializeException();
        }
      }
      return newExperiences;
    }

  }
}
