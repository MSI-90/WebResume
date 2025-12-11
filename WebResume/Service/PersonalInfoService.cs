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
  public sealed class PersonalInfoService : IPersonalInfoService
  {
    private readonly ILogger<PersonalInfoService> _logger;
    private readonly RepositoryContext _context;
    private readonly IMapper _mapper;
    private readonly ICitizenshipService _citizenshipService;
    public PersonalInfoService(
      ILogger<PersonalInfoService> logger, 
      RepositoryContext context, 
      IMapper mapper, 
      ICitizenshipService citizenshipService) 
    {
      _logger = logger;
      _context = context;
      _mapper = mapper;
      _citizenshipService = citizenshipService;
    }

    public async Task CreatePersonalInfoAsync(ResumeForCreationDto resumeDto) 
    { 
      var pInfo = DeserializePInfo(resumeDto);
      if (pInfo is null)
        return;

      var newPersonalInfo = _mapper.Map<PersonalInfo>(pInfo);
      newPersonalInfo.Id = Guid.NewGuid();
      newPersonalInfo.ResumeId = resumeDto.ResumeId;
      newPersonalInfo.Citizenships = await _citizenshipService.GetCitizenShipsThenAnyAsync(resumeDto.CitizenshipIds);

      await _context.PersonalInfos.AddAsync(newPersonalInfo);
      await _context.SaveChangesAsync();
    }

    public bool CheckPInfoAsValid(ResumeForCreationDto resumeDto)
    {
      if (resumeDto is null || string.IsNullOrWhiteSpace(resumeDto.PersonalInfo))
      {
        _logger.LogWarning("Раздел, личная информация отстуствует");
        return false;
      }
      return true;
    }

    public PersonalInfoDto? DeserializePInfo(ResumeForCreationDto resumeDto)
    {
      if (!CheckPInfoAsValid(resumeDto))
        return null;

      try
      {
        return JsonSerializer.Deserialize<PersonalInfoDto>(resumeDto.PersonalInfo!) ?? throw new PersonalInfoDeserializeException();
      }
      catch (JsonException jex)
      {
        _logger.LogError(jex.Message);
        throw new PersonalInfoDeserializeException();
      }
    }
  }
}