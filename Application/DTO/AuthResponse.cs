namespace Finnance.Application.DTO;
public class AuthResponse
{
  public string AcessToken{get; private set;}
  public string RefreshToken{get; private set;}

  private AuthResponse(string acessToken, string refreshToken)
  {
    AcessToken = acessToken;
    RefreshToken = refreshToken;
  }
  public static AuthResponse Create(string acessToken, string refreshToken)
  {
    if(string.IsNullOrWhiteSpace(acessToken) || refreshToken is null)
    {
      throw new ArgumentException("os tokens nao podem ser nulos!");
    }
    return new AuthResponse(acessToken, refreshToken);
  }
}