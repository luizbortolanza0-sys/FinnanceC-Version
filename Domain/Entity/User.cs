namespace Finnance.Domain.Entity;

public class User
{
  public Guid Id { get; private set; }
  public string UserName { get; private set; } 
  private string PasswordHash {get;set;}

  private User(string _userName, string _passwordHash)
  {
    Id = Guid.NewGuid();
    UserName = _userName;
    PasswordHash = _passwordHash;
  }
  public static User Create(string _userName, string _passwordHash)
  {
    if(string.IsNullOrWhiteSpace(_userName))
    {
      throw new ArgumentException("Campo do usuario vazio!");
    }

    if(string.IsNullOrWhiteSpace(_passwordHash))
    {
      throw new ArgumentException("Campo de senha vazio!");
    }

    return new User(_userName,_passwordHash);
  }
}