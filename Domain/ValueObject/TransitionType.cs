namespace Finnance.Domain.ValueObject;

public class TransitionType
{
  public string Type {get; private set;}

  private TransitionType(string _type)
  {
    Type = _type;
  }
  public static TransitionType Create(string _type)
  {
    if (string.IsNullOrWhiteSpace(_type))
    {
      throw new ArgumentException("O tipo nao pode ser nulo!");
    }
    if(!_type.Equals("entrada") || !_type.Equals("saida"))
    {
      throw new ArgumentException("O valor deve ser entrada ou saida!");
    }

    return new TransitionType(_type);
    
  }
}
