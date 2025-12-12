namespace Entites.Exceptions
{
  public class ContactInfoDeserializeException : Exception
  {
    public ContactInfoDeserializeException() : base("There is an error on ContactInfo after JSON deserialize")
    { }
  }
}
