using Finnance.Domain.Entity;
namespace Finnance.Domain.Interface;

public interface IUserRepository
{
  Task SaveAsync (User user);
  Task<User?> GetByIdAsync (Guid userId);
  Task<IEnumerable<User?>> GetAllAsync ();
  Task UpdateAsync (User user);
  Task DeleteAsync (int transacaoId);
}