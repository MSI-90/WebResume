namespace Entites.Exceptions
{
  public class AdditionalInfoDeserializeException : DeserializeException
  {
    public AdditionalInfoDeserializeException() : base("There is an error in the AdditionalInformation after JSON deserialize.")
    {
    }
  }
}
