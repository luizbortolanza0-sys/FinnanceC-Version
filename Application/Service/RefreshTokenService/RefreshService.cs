using Finnance.Domain.Interface;
using Finnance.Domain.Entity;
using Finnance.Application.Interfaces;
using Finnance.Application.DTO;


namespace Finnance.Application.Service.RefreshTokenService;


public class RefreshService(IRefreshTokenRepository Repository, ITokenGenerator tokenGenerator){
  public async Task<RefreshToken> Refresh(string token)
  {
    var dbToken = await Repository.GetByTokenAsync(token);

    if ( dbToken is null  ||  dbToken.Used ||  dbToken.Expired())
    {
      throw new ArgumentException("Refresh Token invalido!");
    }

    dbToken.Use();
    await Repository.SaveAsync(dbToken);
    
    var newToken = RefreshToken.Create(dbToken.UserId, tokenGenerator.RefreshTokenCreate());
    await Repository.SaveAsync(newToken);
    return newToken;
  }
}