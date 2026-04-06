using Finnance.Domain.Interface;
using Finnance.Domain.Entity;
namespace Finnance.Application.Service.TransacaoService;
public class CreateTransacaoService(ITransacaoRepository Repository)
{
  public async Task<Transacao> Execute(
    decimal _value, 
    string _type, 
    string _category, 
    string _name, 
    Guid _userId)
  {
    var transacao = Transacao.Create(_value, _type, _category, _name, _userId);
    await Repository.SaveAsync(transacao, _userId);
    return transacao;
  }
}