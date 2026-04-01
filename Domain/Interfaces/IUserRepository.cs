using Finnance.Domain.Entity;
namespace Finnance.Domain.Interface;

public interface IUserRepository
{
  Task SaveAsync (User _user);
  Task<User?> GetByIdAsync (Guid _userId);
  Task<User?> GetByNameAsync (string _name);
  Task DeleteAsync (Guid _userId);
}