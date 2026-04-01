using Finnance.Domain.Entity;
namespace Finnance.Domain.Interface;

public interface IRefreshTokenRepository
{
  Task SaveAsync (RefreshToken token);
  Task <RefreshToken?> GetByIdAsync (Guid RefreshId);
  Task UpdadeAsync (RefreshToken token);
  Task DeleteAsync (Guid refreshTokenId);

}