using Finnance.Domain.Entity;
namespace Finnance.Domain.Interface;

public interface ITransacaoRepository
{
  Task SaveAsync (Transacao trasacao, Guid userId);
  Task<Transacao?> GetByIdAsync (int transacaoId, Guid userId);
  Task<IReadOnlyList<Transacao>> GetByPages(int pagina, int limite,Guid userId);
  Task<IReadOnlyList<Transacao>> GetAllAsync(Guid userId);
  Task DeleteAsync (int transacaoId, Guid userId);
}