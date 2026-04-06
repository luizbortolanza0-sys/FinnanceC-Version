using Finnance.Domain.Interface;

namespace Finnance.Application.Service.TransacaoService;
public class DeleteTransacaoService(ITransacaoRepository Repository)
{
  public async Task Execute(int _id, Guid _userId)
  {
    var transacao = await Repository.GetByIdAsync(_id, _userId) 
    ?? throw new Exception("Transação não encontrada");

    await Repository.DeleteAsync(_id, _userId);
  }  
}