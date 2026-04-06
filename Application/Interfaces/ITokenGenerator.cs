namespace Finnance.Application.Interfaces;

public interface ITokenGenerator
{
  public string RefreshTokenCreate();
  public string AuthTokenCreate();
}