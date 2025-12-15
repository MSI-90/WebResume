namespace Entites.Exceptions
{
  public class EducationDeserializeException : DeserializeException
  {
    public EducationDeserializeException()
      : base("There is an error in the Education after JSON deserialize")
    {
    }
  }
}
