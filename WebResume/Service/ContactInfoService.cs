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
    public async Task CreateContactinfoAsync(ResumeForCreationDTO resume)
    {
      if (CheckContactInfoAsValid(resume)) return;
      
      var newContact = _mapper.Map<ContactInfo>(resume.ContactInfo);
      newContact.Id = Guid.NewGuid();
      newContact.ResumeId = resume.ResumeId!.Value;
      await _context.ContactInfos.AddAsync(newContact);
      await _context.SaveChangesAsync();
    }

    public bool CheckContactInfoAsValid(ResumeForCreationDTO resume)
    {
        return resume.ContactInfo is null;
    }

  }
}
