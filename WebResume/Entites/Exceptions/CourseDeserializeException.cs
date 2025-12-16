namespace Entites.Exceptions
{
  public class CourseDeserializeException : DeserializeException
  {
    public CourseDeserializeException() : base("There is an error in the Course after JSON deserialize")
    {
    }
  }
}
