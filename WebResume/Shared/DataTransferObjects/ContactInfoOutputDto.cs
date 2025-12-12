namespace Shared.DataTransferObjects
{
  public record ContactInfoOutputDto(
    Guid Id, 
    string Phone, 
    string Email,
    SocialNetworkOutputDto SocialNetwork)
  {
  }
}
