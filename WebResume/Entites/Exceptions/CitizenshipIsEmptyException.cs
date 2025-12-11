namespace Entites.Exceptions
{
  public class CitizenshipIsEmptyException : Exception
  {
    public CitizenshipIsEmptyException() : base("CitizenshipIds is empty!")
    {
    }
  }
}
