namespace Entites.Exceptions
{
  public class DesiredJobInfoDeserializeException : DeserializeException
  {
    public DesiredJobInfoDeserializeException() : base("There is an error on DesiredJob after JSON deserialize")
    {
    }
  }
}
