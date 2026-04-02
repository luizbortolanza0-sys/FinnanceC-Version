using Finnance.Domain.Entity;
namespace Finnance.Domain.Interface;

public interface ITransacaoRepository
{
  Task SaveAsync (Transacao trasacao);
  Task<Transacao?> GetByIdAsync (int transacaoId);
  Task<IReadOnlyList<Transacao>> GetAllAsync();
  Task DeleteAsync (int transacaoId);
}