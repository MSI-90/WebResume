namespace Entites.Exceptions
{
  public class PhotoSizeException : Exception
  {
    public PhotoSizeException() : base("Файл отсутствует, либо размер файла слишком велик.")
    { }
  }
}
