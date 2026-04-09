using Finnance.Domain.Entity;
namespace Finnance.Domain.Interface;

public interface IUserRepository
{
  Task SaveAsync (User user);
  Task<User?> GetByIdAsync (Guid userId);
  Task<User?> GetByNameAsync (string name);
  Task DeleteAsync (Guid userId);
}