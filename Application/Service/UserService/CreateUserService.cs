using Finnance.Domain.Entity;
using Finnance.Domain.Interface;
namespace Finnance.Application.Service.UserService;

public class CreateUserService (IUserRepository Repository, IPasswordHasher PasswordHasher)
{
  public async Task<Guid> Execute(string userName, string password)
  {
    if (string.IsNullOrWhiteSpace(password))
    {
      throw new ArgumentException("A senha nao pode ser nula ou vazia!");
    }
    if (string.IsNullOrWhiteSpace(userName))
    {
      throw new ArgumentException("Username inválido");
    }

    var userForValidation = await Repository.GetByNameAsync(userName);

    if (userForValidation is not null)
    {
      throw new ArgumentException("Usuario ja existente!");
    }    

    var passwordHash = PasswordHasher.Hash(password);
        
    var user = User.Create(userName, passwordHash);

    await Repository.SaveAsync(user);

    return user.Id;
  }
}