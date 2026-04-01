using Finnance.Domain.Entity;
using Finnance.Domain.Interface;
namespace Finnance.Application.Service.UserService;

public class GetUserService (IUserRepository Repository)
{
  public async Task<User> Execute(Guid id)
  {
    var user = await Repository.GetByIdAsync(id)??
      throw new ArgumentException("Usuario não encontrado");

    return user;
  }
}