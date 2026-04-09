using Finnance.Domain.Entity;
using Finnance.Domain.Interface;

namespace Finnance.Application.Service.RefreshTokenService;
public class CreateRefreshTokenService(IRefreshTokenRepository Repository)
{
  public async Task<RefreshToken> Execute(Guid userId, string token)
  {
    var refreshToken =  RefreshToken.Create( userId, token);
    await Repository.SaveAsync(refreshToken);
    return refreshToken;
  }
}