namespace Entites.Models
{
  public class PersonalInfoCitizenship
  {
    public Guid PersonalInfoId { get; set; }
    public PersonalInfo PInfo{ get; set; } = new();
    public Guid CitizenshipsId { get; set; }
    public Citizenship Citizenship { get; set; } = new();
  }
}
