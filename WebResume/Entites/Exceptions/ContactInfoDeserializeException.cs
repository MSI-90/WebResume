namespace Entites.Exceptions
{
  public class ContactInfoDeserializeException : DeserializeException
  {
    public ContactInfoDeserializeException() : base("There is an error on ContactInfo after JSON deserialize")
    { }
  }
}
