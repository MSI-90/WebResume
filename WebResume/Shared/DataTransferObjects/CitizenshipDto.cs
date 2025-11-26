namespace Shared.DataTransferObjects
{
  public record CitizenshipDto
  (
    Guid Id,
    string CountryName, 
    string CountryNameRu, 
    string Alpha2Code, 
    string Alpha3Code, 
    string NumericCode
  )
  {
  }
}
