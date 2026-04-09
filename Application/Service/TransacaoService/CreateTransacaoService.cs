using Finnance.Domain.Interface;
using Finnance.Domain.Entity;
namespace Finnance.Application.Service.TransacaoService;
public class CreateTransacaoService(ITransacaoRepository Repository)
{
  public async Task<Transacao> Execute(
    decimal value, 
    string type, 
    string category, 
    string name, 
    Guid userId)
  {
    var transacao = Transacao.Create(value, type, category, name, userId);
    await Repository.SaveAsync(transacao, userId);
    return transacao;
  }
}