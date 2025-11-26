using AutoMapper;
using Entites.Exceptions;
using Microsoft.EntityFrameworkCore;
using Repository;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
  public sealed class CitizenshipService : ICitizenshipService
  {
    private readonly RepositoryContext _context;
    private readonly IMapper _mapper;
    public CitizenshipService(RepositoryContext context, IMapper mapper)
    {
      _context = context;
      _mapper = mapper;
    }
    public async Task<IEnumerable<CitizenshipDto>> GetCitizenshipsAsync(CancellationToken token)
    {
      var citizenships = await _context.Citizenships
        .AsNoTracking()
        .ToListAsync(token);

      return _mapper.Map<IEnumerable<CitizenshipDto>>(citizenships);
    }

    public async Task<CitizenshipDto> GetCitizenshipAsync(Guid citizenshipGuid, CancellationToken token)
    {
      var citizenship = await _context.Citizenships
        .AsNoTracking()
        .Where(c => c.Id.Equals(citizenshipGuid))
        .FirstOrDefaultAsync(token);

      return _mapper.Map<CitizenshipDto>(citizenship) ?? throw new CitizenshipNotFoundException(citizenshipGuid);
    }
  }
}
