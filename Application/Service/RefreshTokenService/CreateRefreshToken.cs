using Finnance.Domain.Entity;
using Finnance.Domain.Interface;

namespace Finnance.Application.Service.RefreshTokenService;
//Nao finalizada
public class CreateRefreshToken(IRefreshTokenRepository Repository)
{
  public async Task Execute(Guid _userId, string _token)
  {
    var refreshToken =  RefreshToken.Create( _userId, _token);
    await Repository.SaveAsync(refreshToken);
  }
}