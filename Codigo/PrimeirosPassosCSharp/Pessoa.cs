// Este arquivo contém um exdemplo de como estruturar uma classe em C#
// com atributos, construtor e métodos.

public class Pessoa
{
  string? nome;
  string? email;
  string? telefone;

  public Pessoa(string nome, string email, string telefone)
  {
    this.nome = nome;
    this.email = email;
    this.telefone = telefone;
  }

  public void EscreverDados()
  {
    Console.WriteLine("Nome: " + this.nome);
    Console.WriteLine("Email: " + this.email);
    Console.WriteLine("Telefone: " + this.telefone);
  }

  void Teste()
  {
    this.EscreverDados();
  }
}