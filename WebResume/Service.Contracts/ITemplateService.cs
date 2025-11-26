using Shared.DataTransferObjects;

namespace Service.Contracts
{
  public interface ITemplateService
  {
    Task<IEnumerable<TemplateDto>> GetTemplatesAsync(CancellationToken token);
    Task<TemplateDto> GetTemplateByIdAsync(Guid templateId, CancellationToken token);
  }
}
