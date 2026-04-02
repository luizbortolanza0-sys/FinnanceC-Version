using Finnance.Domain.Interface;
using Finnance.Domain.Entity;
namespace Finnance.Application.Service.TransacaoService;

public class GetTransacaoService(ITransacaoRepository Repository)
{
  public async Task<IReadOnlyList<Transacao>> Execute()
  {
    var transacao = await Repository.GetAllAsync();

    return transacao;
  }
}