using Finnance.Domain.ValueObject;
namespace Finnance.Domain.Entity;

public class Transacao
{
  public int Id { get; private set; }
  public Guid UserId { get; private set;}
  public MoneyValue Value { get ; private set;}
  public TransitionType Type { get; private set; } 
  public string Category { get; private set; }
  public string Name { get; private set;}
  public DateTime CreationDateTime {get; private set;}

  private Transacao(MoneyValue value, TransitionType transitionType, string category, string name, Guid userId)
  {
    UserId = userId;
    Value =value;
    Type = transitionType;
    Category = category;
    Name = name;
    CreationDateTime = DateTime.UtcNow;
  }

  public static Transacao Create(decimal value, string type, string category, string name, Guid userId)
  {
    
    var _money = MoneyValue.Create(value);
    var transitionType =  TransitionType.Create(type); 

    if (string.IsNullOrWhiteSpace(category))
    {
      throw new ArgumentException("Categoria nao pode ser um campo vazio!");
    }
    if (string.IsNullOrWhiteSpace(name))
    {
      throw new ArgumentException("Nome da transacao nao pode ser um campo vazio!");
    }
    if(userId == Guid.Empty)
    {
      throw new ArgumentException("Id do usuario invalido!");
    }

    return new Transacao(_money ,transitionType,category,name,userId);
  }
}