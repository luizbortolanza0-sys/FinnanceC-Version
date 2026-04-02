using Finnance.Domain.Entity;
namespace Finnance.Domain.Interface;

public interface IRefreshTokenRepository
{
  Task SaveAsync (RefreshToken token);
  Task <RefreshToken?> GetByIdAsync (Guid RefreshId);
  Task DeleteAsync (Guid refreshTokenId);

}