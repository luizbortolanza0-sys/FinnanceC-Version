namespace Finnance.Application.DTO;
public class AuthResponse
{
  public string AcessToken{get; private set;}
  public string RefreshToken{get; private set;}

  private AuthResponse(string _acessToken, string _refreshToken)
  {
    AcessToken = _acessToken;
    RefreshToken = _refreshToken;
  }
  public static AuthResponse Create(string _acessToken, string _refreshToken)
  {
    if(string.IsNullOrWhiteSpace(_acessToken) || _refreshToken is null)
    {
      throw new ArgumentException("os tokens nao podem ser nulos!");
    }
    return new AuthResponse(_acessToken, _refreshToken);
  }
}