namespace Finnance.Domain.Entity;

class RefreshToken
{
  public Guid Id { get; private set; }
  public Guid UserId { get; private set; }
  public string Token { get; private set; }
  public DateTime ExpiresIn { get; private set; }
  public bool Used { get; private set; }

  private RefreshToken(Guid _userId, string _token)
  {
    Id = Guid.NewGuid();
    UserId = _userId;
    Token = _token;
    ExpiresIn = DateTime.UtcNow.AddDays(7);;
    Used = false;
  }

  public static RefreshToken Create(Guid _userId, string _token)
  {
    if(_userId == Guid.Empty)
    {
      throw new ArgumentException("Id do Usuario nao pode ser Nulo");
    }
    if (string.IsNullOrWhiteSpace(_token))
    {
      throw new ArgumentException("O token nao pode nulo ou vazio!");
    }
    return new RefreshToken(_userId, _token);
  }

  public void Use()
  {
    if (Used)
    {
      throw new ArgumentException("O refresh token ja foi usado!");
    }
    if(ExpiresIn < DateTime.UtcNow)
    {
      throw new ArgumentException("O refresh token expirou!");
    }

    Used = true;
  }
}