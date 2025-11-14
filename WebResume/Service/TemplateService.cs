using AutoMapper;
using Contracts;
using Entites.Exceptions;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
  public sealed class TemplateService : ITemplateService
  {
    private readonly RepositoryContext _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;
    public TemplateService(RepositoryContext repository, ILoggerManager logger, IMapper mapper) 
    {
      _repository = repository;
      _logger = logger;
      _mapper = mapper;
    }

    public async Task<IEnumerable<TemplateDto>> GetTemplatesAsync(CancellationToken token)
    {
      var templates = await _repository.Templates.ToListAsync(token);
      return _mapper.Map<IEnumerable<TemplateDto>>(templates);
    }

    public async Task<TemplateDto> GetTemplateByIdAsync(Guid templateId, CancellationToken token)
    {
      var template = await _repository.Templates.Where(t => t.TemplateId.Equals(templateId)).FirstOrDefaultAsync(token);
      return _mapper.Map<TemplateDto>(template) ?? throw new TemplateNotFoundException(templateId);
    }
  }
}
