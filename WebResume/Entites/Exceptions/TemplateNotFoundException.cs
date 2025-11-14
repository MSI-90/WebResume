namespace Entites.Exceptions
{
  public class TemplateNotFoundException : NotFoundException
  {
    public TemplateNotFoundException(Guid templateId) : base($"Шаблон с id: {templateId} не найден в базе данных.")
    {
    }
  }
}
