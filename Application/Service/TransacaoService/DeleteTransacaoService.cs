using Finnance.Domain.Interface;

namespace Finnance.Application.Service.TransacaoService;
public class DeleteTransacaoService(ITransacaoRepository Repository)
{
  public async Task Execute(int _id)
  {
    var transacao = await Repository.GetByIdAsync(_id) 
    ?? throw new Exception("Transação não encontrada");

    await Repository.DeleteAsync(_id);
  }  
}