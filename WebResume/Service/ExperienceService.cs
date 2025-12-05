using AutoMapper;
using Contracts;
using Entites.Exceptions;
using Entites.Models;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;
using System.Text.Json;

namespace Service
{
  public sealed class ExperienceService : IExperienceService
  {
    private readonly RepositoryContext _context;
    private readonly ILoggerManager _loggerManager;
    private readonly IMapper _mapper;
    public ExperienceService(RepositoryContext context, ILoggerManager logger, IMapper mapper) 
    {
      _context = context;
      _loggerManager = logger;
      _mapper = mapper;
    }

    public async Task<IEnumerable<Experience?>> GetExperienceAsync(Guid resumeId, CancellationToken token) => 
      await _context.Experience
      .Where(e => e.ResumeId.Equals(resumeId))
      .ToListAsync(token);
    
    public async Task<IEnumerable<Experience?>> CreateExperienceAsync(Guid resumeId, IEnumerable<string>? experience)
    {
      if (experience is null || !experience.Any())
        return Enumerable.Empty<Experience>();

      var newExperiences = new List<Experience>();
      foreach (var item in experience)
      {
        // TODO пересмотреть if (dto is null) здесь
        try 
        {
          var experienceItem = JsonSerializer.Deserialize<ExperienceForCreationDto>(item) ?? throw new ExperienceDeserializeException();
          var newExp = _mapper.Map<Experience>(experienceItem);
          newExp.Id = Guid.NewGuid();
          newExp.ResumeId = resumeId;
          newExperiences.Add(newExp);
        }
        catch (Exception ex)
        {
          _loggerManager.LogError(ex.Message);
          throw new ExperienceDeserializeException();
        }
      }

      await _context.Experience.AddRangeAsync(newExperiences);
      await _context.SaveChangesAsync();

      return await GetExperienceAsync(resumeId, default);
    }
  }
}
