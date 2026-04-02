using Finnance.Domain.Entity;
using Finnance.Domain.Interface;

namespace Finnance.Application.Service.RefreshTokenService;
public class CreateRefreshTokenService(IRefreshTokenRepository Repository)
{
  public async Task<RefreshToken> Execute(Guid _userId, string _token)
  {
    var refreshToken =  RefreshToken.Create( _userId, _token);
    await Repository.SaveAsync(refreshToken);
    return refreshToken;
  }
}