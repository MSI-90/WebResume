using AutoMapper;
using Contracts;
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
        var dto = JsonSerializer.Deserialize<ExperienceForCreationDto>(item);
        if (dto is null)
          throw new Exception("Experience is null after JSON deserialize");

        var newExp = _mapper.Map<Experience>(dto);
        newExp.Id = Guid.NewGuid();
        newExp.ResumeId = resumeId;

        newExperiences.Add(newExp);
      }

      await _context.Experience.AddRangeAsync(newExperiences);
      await _context.SaveChangesAsync();

      return await GetExperienceAsync(resumeId, default);
    }
  }
}
