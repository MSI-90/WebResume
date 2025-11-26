using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface ICitizenshipService
  {
    Task<IEnumerable<CitizenshipDto>> GetCitizenshipsAsync(CancellationToken token);
    Task<CitizenshipDto> GetCitizenshipAsync(Guid citizenshipGuid, CancellationToken token);
  }
}
