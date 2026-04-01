using Finnance.Domain.Entity;
using Finnance.Domain.Interface;
namespace Finnance.Application.Service.UserService;

public class CreateUserService (IUserRepository Repository, IPasswordHasher PasswordHasher)
{
  public async Task<Guid> Execute(string _userName, string _password)
  {
    if (string.IsNullOrWhiteSpace(_password))
    {
      throw new ArgumentException("A senha nao pode ser nula ou vazia!");
    }
    if (string.IsNullOrWhiteSpace(_userName))
    {
      throw new ArgumentException("Username inválido");
    }

    var userForValidation = await Repository.GetByNameAsync(_userName);

    if (userForValidation is not null)
    {
      throw new ArgumentException("Usuario ja existente!");
    }    

    var passwordHash = PasswordHasher.Hash(_password);
        
    var user = User.Create(_userName, passwordHash);

    await Repository.SaveAsync(user);

    return user.Id;
  }
}