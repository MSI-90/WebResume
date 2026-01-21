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
  public class ComputerSkillService : IComputerSkillService
  {
    private readonly ILogger<ComputerSkillService> _logger;
    private readonly RepositoryContext _repository;
    private readonly IMapper _mapper;
    public ComputerSkillService(RepositoryContext repository, ILogger<ComputerSkillService> logger, IMapper mapper)
    {
      _repository = repository;
      _logger = logger;
      _mapper = mapper;
    }

    public async Task CreateCSkillAsync(ResumeForCreationDTO resume)
    {
      if (!CheckCSkillsAsValid(resume)) return;

      var newSkills = new List<ComputerSkill>();
      foreach (var item in resume.Skills!)
      {
        var newLang = _mapper.Map<ComputerSkill>(item);
        newLang.Id = Guid.NewGuid();
        newLang.ResumeId = resume.ResumeId!.Value;
        newSkills.Add(newLang);
      }

      await _repository.ComputerSkills.AddRangeAsync(newSkills);
      await _repository.SaveChangesAsync();
    }

    public bool CheckCSkillsAsValid(ResumeForCreationDTO resume) =>
      resume.Skills is not null && resume.Skills.Any();

  }
}
