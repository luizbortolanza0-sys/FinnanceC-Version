using Finnance.Domain.Entity;
using Finnance.Domain.Interface;

namespace Finnance.Application.Service.RefreshTokenService;
public class GetRefreshToken(IRefreshTokenRepository Repository)
{
  public async Task<RefreshToken?> Execute(Guid id)
  {
    if(id == Guid.Empty)
    {
      throw new ArgumentException("O Id do refresh token nao pode ser nulo");
    }
    
    var refreshToken = await Repository.GetByIdAsync(id)?? throw new ArgumentException("RefreshToken nao foi encontrado!");

    return refreshToken;
  }
}