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

    public async Task CreateAdditionalInfoAsync(ResumeForCreationDTO resume)
    {
      if (CheckAdditionalInfoAsValid(resume)) return;

      var newAdditional = _mapper.Map<AdditionalInformation>(resume.AdditionalInfo);

      newAdditional.Id = Guid.NewGuid();
      newAdditional.ResumeId = resume.ResumeId!.Value;
      await _context.AdditionalInformations.AddAsync(newAdditional);
      await _context.SaveChangesAsync();
    }

    public bool CheckAdditionalInfoAsValid(ResumeForCreationDTO resume) =>
      resume.AdditionalInfo is null;

  }
}
