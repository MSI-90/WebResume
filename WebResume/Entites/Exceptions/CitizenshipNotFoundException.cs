using Entites.Models;

namespace Entites.Exceptions
{
  public class CitizenshipNotFoundException : NotFoundException
  {
    public CitizenshipNotFoundException(Guid citizenshipId) : base($"Гражданство с id: {citizenshipId} не найдено в базе данных.")
    {
    }
  }
}
