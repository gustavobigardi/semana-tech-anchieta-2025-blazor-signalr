// Este bloco de código demonstra o uso das classes definidas em FormaPagamento.cs, Pessoa.cs e Animal.cs.
FormaPagamento pgto = new CartaoCredito(100.50m);
decimal valorFinal = pgto.ValorFinal();
pgto.ImprimeTipoPagamento();
Console.WriteLine("Valor Pagamento: " + valorFinal.ToString("#.00"));


Pessoa p = new Pessoa("Gustavo", "gbbigardi@gmail.com", "123123   123");
p.EscreverDados();


Pessoa p2 = new Pessoa("Joao", "joao@gmail.com", "123123");
p2.EscreverDados();

Animal animal1 = new Cachorro();
Animal animal2 = new Gato();

animal1.ProduzirSom();
animal2.ProduzirSom();

// Este bloco demonstra como utilizar a escrita e leitura no console, estruturas de controle como if, switch, while e for, além de tratamento de exceções.

Console.WriteLine("Hello, World 1!");
Console.WriteLine("Hello, World 2!");
Console.WriteLine("Hello, World 3!");

Console.ReadKey();

string? nome;
int idade;

Console.Write("Informe seu nome: ");
nome = Console.ReadLine();

Console.WriteLine("Nome Digitado: " + nome);

try
{
  Console.Write("Informe sua idade: ");
  idade = int.Parse(Console.ReadLine());

  switch (idade)
  {
    case 40:
      Console.WriteLine("Idade = 40");
      break;
    case 41:
      Console.WriteLine("Idade = 41");
      break;
    default:
      while (idade != 40 && idade != 41)
      {
        Console.Write("Muito novo. Informe sua idade novamente: ");
        idade = int.Parse(Console.ReadLine());
      }
      break;
  }

  while (idade < 40)
  {
    Console.Write("Muito novo. Informe sua idade novamente: ");
    idade = int.Parse(Console.ReadLine());
  }

  int contadorWhile = 0;

  while (contadorWhile < 10)
  {
    Console.WriteLine("ContadorWhile: " + contadorWhile);

    if (contadorWhile > 5)
    {
      Console.WriteLine("PAROU WHILE!");
      break;
    }

    contadorWhile++;
  }

  for (int contador = 1; contador <= 20; contador++)
  {
    if (contador < 5)
    {
      Console.WriteLine("Pulando o numero");
      continue;
    }

    Console.WriteLine("Contador: " + contador);

    if (contador > 10)
    {
      Console.WriteLine("PAROU!");
      break;
    }
  }

  Console.WriteLine("Idade digitada: " + idade.ToString());
}
catch (FormatException)
{
  Console.WriteLine("Voce digitou uma idade em formato invalido");
}
catch (Exception)
{
  Console.WriteLine("Ocorreu um erro ao processar sua idade");
}
finally
{
  Console.WriteLine("Terminou de processar a idade");
}


