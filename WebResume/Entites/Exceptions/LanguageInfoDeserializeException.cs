namespace Entites.Exceptions
{
  public class LanguageInfoDeserializeException : DeserializeException
  {
    public LanguageInfoDeserializeException() : base("There is an error in the LanguageInfo after JSON deserialize.")
    {
    }
  }
}
