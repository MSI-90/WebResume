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
  public class ContactInfoService : IContactInfoService
  {
    private readonly ILogger<ContactInfoService> _logger;
    private readonly RepositoryContext _context;
    private readonly IMapper _mapper;
    public ContactInfoService(ILogger<ContactInfoService> logger, RepositoryContext context, IMapper mapper) 
    {
      _logger = logger;
      _context = context;
      _mapper = mapper;
    }
    public async Task CreateContactinfoAsync(ResumeForCreationDto resume)
    {
      var contactInfo = DeserilizeContactInfo(resume);
      if (contactInfo is null)
        return;

      var newContact = _mapper.Map<ContactInfo>(contactInfo);
      newContact.Id = Guid.NewGuid();
      newContact.ResumeId = resume.ResumeId!.Value;
      await _context.ContactInfos.AddAsync(newContact);
      await _context.SaveChangesAsync();
    }

    public bool CheckContactInfoAsValid(ResumeForCreationDto resume)
    {
      if (string.IsNullOrWhiteSpace(resume.ContactInfo))
        return false;

      return true;
    }

    public ContactInfoForCreationDto? DeserilizeContactInfo(ResumeForCreationDto resume)
    {
      if (!CheckContactInfoAsValid(resume))
        return null;

      try
      {
        return JsonSerializer.Deserialize<ContactInfoForCreationDto>(resume.ContactInfo!) ?? throw new ContactInfoDeserializeException();
      }
      catch (JsonException jex)
      {
        _logger.LogWarning(jex.Message);
        throw new ContactInfoDeserializeException();
      }
    }
  }
}
