using Entites.Models;

namespace Entites.Exceptions
{
  public class PhotoNotFoundException : NotFoundException
  {
    public PhotoNotFoundException(Guid photoId) : base($"Файл с id: {photoId} не найдено в базе данных.")
    {
    }
  }
}
