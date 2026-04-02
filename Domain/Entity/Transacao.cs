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

  private Transacao(MoneyValue _value, TransitionType _transitionType, string _category, string _name, Guid _userId)
  {
    UserId = _userId;
    Value =_value;
    Type = _transitionType;
    Category = _category;
    Name = _name;
    CreationDateTime = DateTime.UtcNow;
  }

  public static Transacao Create(decimal _value, string _type, string _category, string _name, Guid _userId)
  {
    
    var _money = MoneyValue.Create(_value);
    var _transitionType =  TransitionType.Create(_type); 

    if (string.IsNullOrWhiteSpace(_category))
    {
      throw new ArgumentException("Categoria nao pode ser um campo vazio!");
    }
    if (string.IsNullOrWhiteSpace(_name))
    {
      throw new ArgumentException("Nome da transacao nao pode ser um campo vazio!");
    }
    if(_userId == Guid.Empty)
    {
      throw new ArgumentException("Id do usuario invalido!");
    }

    return new Transacao(_money ,_transitionType,_category,_name,_userId);
  }
}