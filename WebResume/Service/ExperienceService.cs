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
    
    public async Task CreateExperienceAsync(ResumeForCreationDTO resume)
    {
      if (!CheckExperienceAsValid(resume)) return;

      var newExperiences = new List<Experience>();
      foreach (var item in resume.Experience!)
      {
        var newExp = _mapper.Map<Experience>(item);
        newExp.Id = Guid.NewGuid();
        newExp.ResumeId = resume.ResumeId!.Value;
        newExperiences.Add(newExp);
      }

      await _context.Experience.AddRangeAsync(newExperiences);
      await _context.SaveChangesAsync();
    }

    public bool CheckExperienceAsValid(ResumeForCreationDTO resume) => 
      resume.Experience is not null && resume.Experience.Any();

  }
}
