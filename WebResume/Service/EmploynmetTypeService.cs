using Entites.Enums;
using Entites.Enums.Extends;
using Microsoft.Extensions.Logging;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service
{
  public sealed class EmploynmetTypeService : IEmploynmetTypeService
  {
    private readonly ILogger<EmploynmetTypeService> _logger;
    public EmploynmetTypeService(ILogger<EmploynmetTypeService> logger)
    {
      _logger = logger;
    }

    public IEnumerable<EmploynmetTypeDto> GetEmploymentTypes()
    {
      var employmentTypes = Enum.GetValues<EmploymentType>();
      uint id = 0;
      return employmentTypes
        .Select(et => new EmploynmetTypeDto(id++, et.GetDisplayName(), et.ToString()))
        .ToList();
    }
  }
}
