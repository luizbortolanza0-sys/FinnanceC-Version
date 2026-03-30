namespace Finnance.Domain.Interface;

public interface IPasswordHasher
{
  string Hash(string _password);
  bool Verify(string _password, string _hash);
}