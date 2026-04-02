namespace Finnance.Domain.ValueObject;

public class MoneyValue : IEquatable<MoneyValue>
{
  public decimal Amount {get; private set;}

  private MoneyValue(decimal _value)
  {
    Amount = _value;
  }

  public static MoneyValue Create(decimal _value)
  {
    if (_value <= 0)
    {
      throw new ArgumentException("O valor deve ser positivo e maior que zero!");
    }

    return new MoneyValue(_value);
  }
  public bool Equals(MoneyValue? money) => money is not null && Amount == money.Amount;
  

}