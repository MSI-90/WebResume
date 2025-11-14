namespace Entites.Exceptions
{
  public class ResumeNotFoundException : NotFoundException
  {
    public ResumeNotFoundException(Guid resumeId) : base($"Резюме с id: {resumeId} не найдено в базе данных")
    {
    }
  }
}
