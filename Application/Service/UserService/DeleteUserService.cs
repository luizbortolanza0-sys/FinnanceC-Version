using Finnance.Domain.Interface;
namespace Finnance.Application.Service.UserService;

public class DeleteUserService (IUserRepository Repository)
{
  public async Task Execute(Guid id)
  {
    var user = await Repository.GetByIdAsync(id) 
      ??throw new Exception("Usuário não encontrado");
      
    await Repository.DeleteAsync(id);
  }
}