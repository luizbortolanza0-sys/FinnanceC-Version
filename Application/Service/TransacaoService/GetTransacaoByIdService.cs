using Finnance.Domain.Interface;
using Finnance.Domain.Entity;
namespace Finnance.Application.Service.TransacaoService;

public class GetTransacaoByIdService(ITransacaoRepository Repository)
{
  public async Task<Transacao?> Execute(int transacaoId, Guid userId)
  {

    if (transacaoId <= 0)
    throw new ArgumentException("Id inválido");

    var transacao = await Repository.GetByIdAsync(transacaoId, userId)??
      throw new ArgumentException("Transacao não encontrada");

    return transacao;
  
  }
}