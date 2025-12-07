namespace Entites.Exceptions
{
  public class PhotoBigSizeException : Exception
  {
    public PhotoBigSizeException() : base("Файл отсутствует, либо размер файла слишком велик.")
    { }
  }
}
