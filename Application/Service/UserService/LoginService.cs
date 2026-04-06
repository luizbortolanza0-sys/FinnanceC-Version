using Finnance.Application.DTO;
using Finnance.Application.Interfaces;
using Finnance.Domain.Entity;
using Finnance.Domain.Interface;

namespace Finnance.Application.Service.UserService;

public class LoginService( IUserRepository Repository ,IRefreshTokenRepository RefreshTokenRepository,IPasswordHasher PasswordHasher, ITokenGenerator TokenGenerator)
{
  public async Task<AuthResponse> Execute(string login, string password)
  {
    var user = await Repository.GetByNameAsync(login)?? throw new ArgumentException("Usuario ou senha invalido!");

    if (!PasswordHasher.Verify(password, user.PasswordHash))
    {
      throw new ArgumentException("Usuario ou senha invalido!");  
    }
    
    var newToken = RefreshToken.Create(user.Id, TokenGenerator.RefreshTokenCreate());
    await RefreshTokenRepository.SaveAsync(newToken);

    return AuthResponse.Create(TokenGenerator.AuthTokenCreate(), newToken.Token);
  }
}