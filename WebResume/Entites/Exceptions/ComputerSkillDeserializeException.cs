namespace Entites.Exceptions
{
  public class ComputerSkillDeserializeException : DeserializeException
  {
    public ComputerSkillDeserializeException() : base("There is an error in the ComputerSkill after JSON deserialize.")
    {
    }
  }
}
