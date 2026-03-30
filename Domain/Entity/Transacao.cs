using Finnance.Domain.ValueObject;
namespace Finnance.Domain.Entity;

public class Transacao
{
  public int Id { get; private set; }
  public Guid UserId { get; private set;}
  public double Value { get ; private set;}
  public TransitionType Type { get; private set; } 
  public string Category { get; private set; }
  public string Name { get; private set;}
  
  public DateTime CreationDateTime {get; private set;}

  private Transacao(double _value, TransitionType _type, string _category, string _name, Guid _userId)
  {
    UserId = _userId;
    Value =_value;
    Type = _type;
    Category = _category;
    Name = _name;
  }

  public static Transacao Create(double _value, TransitionType _type, string _category, string _name, Guid _userId)
  {
    if(_value<= 0)
    {
      throw new ArgumentException("O valor deve ser maior que zero!");
    }
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

    return new Transacao(_value,_type,_category,_name,_userId);
  }
}