// Este arquivo define a classe abstrata Animal e suas subclasses Cachorro e Gato.
// Demonstrando o uso de herança e métodos abstratos.

public abstract class Animal
{
  public abstract void ProduzirSom();
}

public class Cachorro : Animal
{
  public override void ProduzirSom()
  {
    Console.WriteLine("AuAu");
  }
}

public class Gato : Animal
{
  public override void ProduzirSom()
  {
    Console.WriteLine("Miau");
  }
}