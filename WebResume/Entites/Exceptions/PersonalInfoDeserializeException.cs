namespace Entites.Exceptions
{
  public class PersonalInfoDeserializeException : Exception
  {
    public PersonalInfoDeserializeException() : base("There is an error on Personalinfo after JSON deserialize")
    { }
  }
}
