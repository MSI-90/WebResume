namespace Entites.Exceptions
{
  public class PhotoBigSizeException : Exception
  {
    public PhotoBigSizeException() : base("Слишком большой размер файла.")
    { }
  }
}
