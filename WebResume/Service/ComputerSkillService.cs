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

    public async Task CreateCSkillAsync(ResumeForCreationDto resume)
    {
      var computerSkills = DeserializeComputerSkillExperience(resume);
      await _repository.ComputerSkills.AddRangeAsync(computerSkills);
      await _repository.SaveChangesAsync();
    }

    public bool CheckCSkillsAsValid(ResumeForCreationDto resume) =>
      resume.Skills is not null && resume.Skills.Any();

    public List<ComputerSkill> DeserializeComputerSkillExperience(ResumeForCreationDto resume)
    {
      if (!CheckCSkillsAsValid(resume))
        return new List<ComputerSkill>();

      var newSkills = new List<ComputerSkill>();
      foreach (var item in resume.Skills!)
      {
        try
        {
          var computerSkillItem = JsonSerializer.Deserialize<ComputerSkillForCreationDto>(item) ?? throw new ComputerSkillDeserializeException();
          var newLang = _mapper.Map<ComputerSkill>(computerSkillItem);
          newLang.Id = Guid.NewGuid();
          newLang.ResumeId = resume.ResumeId!.Value;
          newSkills.Add(newLang);
        }
        catch (JsonException jex)
        {
          _logger.LogWarning(jex.Message);
          throw new ComputerSkillDeserializeException();
        }
      }
      return newSkills;
    }
  }
}
