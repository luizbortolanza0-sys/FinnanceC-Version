namespace Finnance.Domain.ValueObject;

public class MoneyValue : IEquatable<MoneyValue>
{
  public decimal Amount {get; private set;}

  private MoneyValue(decimal value)
  {
    Amount = value;
  }

  public static MoneyValue Create(decimal value)
  {
    if (value <= 0)
    {
      throw new ArgumentException("O valor deve ser positivo e maior que zero!");
    }

    return new MoneyValue(value);
  }
  public bool Equals(MoneyValue? money) => money is not null && Amount == money.Amount;
  

}