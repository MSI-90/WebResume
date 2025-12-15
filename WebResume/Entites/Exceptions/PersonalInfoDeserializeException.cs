namespace Entites.Exceptions
{
  public class PersonalInfoDeserializeException : DeserializeException
  {
    public PersonalInfoDeserializeException() 
      : base("There is an error on Personalinfo after JSON deserialize")
    { }
  }
}
