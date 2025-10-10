// Este arquivo define a classe abstrata FormaPagamento e suas subclasses CartaoCredito e Boleto.
// Demonstrando o uso de herança, métodos abstratos e sobrescrita de métodos.

public abstract class FormaPagamento
{
  public decimal valor;

  public abstract decimal ValorFinal();

  public virtual void ImprimeTipoPagamento()
  {
    Console.WriteLine(this.GetType().Name);
  }
}

public class CartaoCredito : FormaPagamento
{
  public CartaoCredito(decimal valor)
  {
    this.valor = valor;
  }

  public override decimal ValorFinal()
  {
    return this.valor;
  }

  public override void ImprimeTipoPagamento()
  {
    Console.WriteLine("CC");
  }
}

public class Boleto : FormaPagamento
{
  public Boleto(decimal valor)
  {
    this.valor = valor;
  }

  public override decimal ValorFinal()
  {
    return this.valor * 0.9m;
  }
}