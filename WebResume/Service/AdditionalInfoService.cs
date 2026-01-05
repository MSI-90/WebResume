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
  public sealed class AdditionalInfoService : IAdditionalInfoService
  {
    private readonly ILogger<AdditionalInfoService> _logger;
    private readonly RepositoryContext _context;
    private readonly IMapper _mapper;
    public AdditionalInfoService(ILogger<AdditionalInfoService> logger, RepositoryContext context, IMapper mapper)
    {
      _logger = logger;
      _context = context;
      _mapper = mapper;
    }

    public async Task CreateAdditionalInfoAsync(ResumeForCreationDto resume)
    {
      var newAdditioanlInfoDto = DeserializeAdditionalInfo(resume);
      var newAdditional = _mapper.Map<AdditionalInformation>(newAdditioanlInfoDto);
      newAdditional.Id = Guid.NewGuid();
      newAdditional.ResumeId = resume.ResumeId!.Value;
      await _context.AdditionalInformations.AddAsync(newAdditional);
      await _context.SaveChangesAsync();
    }

    public bool CheckAdditionalInfoAsValid(ResumeForCreationDto resume) =>
      resume.AdditionalInfo is not null && resume.AdditionalInfo.Any();

    public AdditionalInfoForCreationDto? DeserializeAdditionalInfo(ResumeForCreationDto resumeDto)
    {
      if (!CheckAdditionalInfoAsValid(resumeDto))
        return null;

      try
      {
        return JsonSerializer.Deserialize<AdditionalInfoForCreationDto>(resumeDto.AdditionalInfo!) ?? throw new AdditionalInfoDeserializeException();
      }
      catch (JsonException jex)
      {
        _logger.LogError(jex.Message);
        throw new AdditionalInfoDeserializeException();
      }
    }
  }
}
