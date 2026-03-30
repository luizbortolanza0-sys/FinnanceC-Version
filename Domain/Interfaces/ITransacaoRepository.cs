using Finnance.Domain.Entity;
namespace Finnance.Domain.Interface;

public interface ITransacaoRepository
{
  Task SaveAsync (Transacao trasacao);
  Task<Transacao?> GetByIdAsync (int transacaoId);
  Task<IEnumerable<Transacao?>> GetAllAsync ();
  Task UpdateAsync (Transacao transacao);
  Task DeleteAsync (int transacaoId);
}