namespace Entites.Exceptions
{
  public class DesiredJobInfoDeserializeException : DeserializeException
  {
    public DesiredJobInfoDeserializeException() : base("DesiredJob is null after JSON deserialize")
    {
    }
  }
}
