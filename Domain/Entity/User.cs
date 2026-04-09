namespace Finnance.Domain.Entity;

public class User
{
  public Guid Id { get; private set; }
  public string UserName { get; private set; } 
  public string PasswordHash {get; private set;}

  private User(string userName, string passwordHash)
  {
    Id = Guid.NewGuid();
    UserName = userName;
    PasswordHash = passwordHash;
  }
  public static User Create(string userName, string passwordHash)
  {
    if(string.IsNullOrWhiteSpace(userName))
    {
      throw new ArgumentException("Campo do usuario vazio!");
    }

    if(string.IsNullOrWhiteSpace(passwordHash))
    {
      throw new ArgumentException("Campo de senha vazio!");
    }

    return new User(userName, passwordHash);
  }
}