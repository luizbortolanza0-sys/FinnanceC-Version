using Finnance.Domain.Interface;

namespace Finnance.Application.Service.TransacaoService;
public class DeleteTransacaoService(ITransacaoRepository Repository)
{
  public async Task Execute(int id, Guid userId)
  {
    var transacao = await Repository.GetByIdAsync(id, userId) 
    ?? throw new Exception("Transação não encontrada");

    await Repository.DeleteAsync(id, userId);
  }  
}