using Finnance.Domain.Entity;
using Finnance.Domain.Interface;
namespace Finnance.Application.Service.UserService;

public class GetUserByNameService (IUserRepository Repository)
{
  public async Task<User?> Execute(string _name)
  {
    if(string.IsNullOrWhiteSpace(_name)) throw new ArgumentException("Nome nao pode ser nulo ou vazio!");

    return await Repository.GetByNameAsync(_name);
  }
}