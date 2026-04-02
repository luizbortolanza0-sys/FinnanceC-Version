using Finnance.Domain.Interface;

namespace Finnance.Application.Service.RefreshTokenService;
//Nao finalizada
public class DeleteRefreshToken(IRefreshTokenRepository Repository)
{
  public async Task Execute(Guid id)
  {
    if(id == Guid.Empty)
    {
      throw new ArgumentException("O id nao pode ser nulo ou vazio!");
    }
    await Repository.DeleteAsync(id);
  }
}