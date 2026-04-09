namespace Finnance.Domain.ValueObject;

public class TransitionType
{
  public string Type {get; private set;}

  private TransitionType(string type)
  {
    Type = type;
  }
  public static TransitionType Create(string type)
  {
    if (string.IsNullOrWhiteSpace(type))
    {
      throw new ArgumentException("O tipo nao pode ser nulo!");
    }
    if(!type.Equals("entrada") && !type.Equals("saida"))
    {
      throw new ArgumentException("O valor deve ser entrada ou saida!");
    }

    return new TransitionType(type);
  }
}
