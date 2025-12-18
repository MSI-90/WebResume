namespace Entites.Exceptions
{
  public class LanguageInfoDeserializeException : Exception
  {
    public LanguageInfoDeserializeException() : base("There is an error in the LanguageInfo after JSON deserialize.")
    {
    }
  }
}
