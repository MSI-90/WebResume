namespace Entites.Models
{
  public class ResumeCitizenship
  {
    public Guid ResumesId { get; set; }
    public Resume Resume { get; set; } = new();
    public Guid CitizenshipsId { get; set; }
    public Citizenship Citizenship { get; set; } = new();
  }
}
