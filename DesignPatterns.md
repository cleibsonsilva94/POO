### Abaixo, padrões de projeto mais utilizados.

 Mas o que são padrões de projeto? São soluções que já foram aplicadas por outros 
 desenvolvedores e podem ser replicadas por nós mesmos para solucionar problemas comuns. 
 A ideia é reutilizar soluções que já deram certo.


### Strategy

```
namespace ExemploStrategy
{

  class Program {
    public static void Main (string[] args)    {
      
      //Primeiro pedido a ser pago com PIX
      Pedido p1 = new Pedido();
      PIX novoObjetoPix = new PIX("123.456.789-10");
      p1.Pagar(novoObjetoPix, 100);

      //Primeiro pedido a ser pago com Cartão de Crédito
      Pedido p2 = new Pedido();
      CartaoCredito novoObjetoCartao = new CartaoCredito(2);
      p2.Pagar(novoObjetoCartao, 200);

      Pedido p3 = new Pedido();

      Dinheiro dindin = new Dinheiro();
      p3.Pagar(dindin, 300);
      
   }
  }

}
```

```
namespace ExemploStrategy
{

  public interface IPagamento
  {
    void Pagar(int quantia);
  }
  
}

```

```

using System;

namespace ExemploStrategy{

  public class Dinheiro:IPagamento{

      public Dinheiro(){
        
      }

      public void Pagar(int quantia){
        Console.WriteLine("Pagando com Dinheiro..." + quantia);
      }
    
  }

}

```

```
using System;

namespace ExemploStrategy{

  public class CartaoCredito : IPagamento{

    public int Parcelas {get; set;}
    
    public CartaoCredito(int parcelas){
        this.Parcelas = parcelas;
    }
    
    public void Pagar(int quantia){
      Console.WriteLine("Pagto com cartão: " + quantia + " em: " + this.Parcelas + " vezes");
    }
    
  }

}

```

```
namespace ExemploStrategy{

  public class Pedido{

    public Pedido(){
      
    }
    
    public void Pagar(IPagamento metodo, int quantia){
        metodo.Pagar(quantia);      
    }
    
  }
  
  
}

```

```
using System;

namespace ExemploStrategy{

  public class PIX:IPagamento{

    public String ChavePIX {get; set;}
    
    public PIX(String chavePix){
      this.ChavePIX = chavePix;
    }
    
    public void Pagar(int quantia){
      Console.WriteLine("Pagto com PIX: " + quantia + " chave pix: " + this.ChavePIX);
    }
    
  }

}

```
