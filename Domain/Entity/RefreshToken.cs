namespace Finnance.Domain.Entity;

public class RefreshToken
{
  public Guid Id { get; private set; }
  public Guid UserId { get; private set; }
  public string Token { get; private set; }
  public DateTime ExpiresIn { get; private set; }
  public bool Used { get; private set; }

  private RefreshToken(Guid userId, string token)
  {
    Id = Guid.NewGuid();
    UserId = userId;
    Token = token;
    ExpiresIn = DateTime.UtcNow.AddDays(7);
    Used = false;
  }

  public static RefreshToken Create(Guid userId, string token)
  {
    if(userId == Guid.Empty)
    {
      throw new ArgumentException("Id do Usuario nao pode ser Nulo");
    }
    if (string.IsNullOrWhiteSpace(token))
    {
      throw new ArgumentException("O token nao pode nulo ou vazio!");
    }
    return new RefreshToken(userId, token);
  }

  public void Use()
  {
    if (Used)
    {
      throw new ArgumentException("O refresh token ja foi usado!");
    }
    if (DateTime.UtcNow > ExpiresIn)
    {
      throw new ArgumentException("O refresh token expirou!");
    }

    Used = true;
  }
  public bool Expired() => DateTime.UtcNow > ExpiresIn;
}