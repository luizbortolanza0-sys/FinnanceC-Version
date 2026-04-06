using Finnance.Domain.Interface;
using Finnance.Domain.Entity;
namespace Finnance.Application.Service.TransacaoService;

public class GetTransacaoService(ITransacaoRepository Repository)
{
  public async Task<IReadOnlyList<Transacao>> Execute(Guid userId)
  {
    var transacao = await Repository.GetAllAsync(userId);

    return transacao;
  }
}