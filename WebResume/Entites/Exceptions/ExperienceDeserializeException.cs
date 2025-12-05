namespace Entites.Exceptions
{
  public class ExperienceDeserializeException : DeserializeException
  {
    public ExperienceDeserializeException() : base("Experience is null after JSON deserialize")
    {
    }
  }
}
