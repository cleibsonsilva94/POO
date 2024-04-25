using System;

public class Imovel
{

    #region CamposPropriedades
    //Defino os atributos (campos)
    private int numComodos = 0;

    //Atributo estático
    private static String nomeIncorporadora = "EZTEC"; //Variaveis da classe
    private static int numInstancias = 0;

    //Defino as propriedades já com os getters e setters  
    public int NumSuites { get; set; } = 1; // Propriedades que são alteradas 
    public String Endereco { get; set; }

    public bool Alugado { get; set; } = false; 

    //Defino um atributo
    private int metragem;

    //Defino a propriedade para alterar o atributo metragem
    public int Metragem
    {
        set
        {
            //Permito apenas valores positivos
            if (value > 0)
            {
                this.metragem = value;
            }
        }
        get
        {
            return this.metragem;
        }
    } // Fim da propriedade Metragem

    public int GetNumComodos()
    {
        return this.numComodos;
    }

    public void SetNumComodos(int numComodos)
    {
        this.numComodos = numComodos;
    }

    //Método estático
    public static int GetNumInstancias()
    {
        return numInstancias;
    }

    public static String GetNomeIncorporadora()
    {
        return nomeIncorporadora;
    }

    #endregion

    // Construtores
    public Imovel()
    {
        this.numComodos = 1;

        //Toda vez que construo um objeto, incremento o número de instâncias
        Imovel.numInstancias++;
    }

    //Construtor com parâmetros
    public Imovel(int numComodos)
    {
        this.numComodos = numComodos;

        //Toda vez que construo um objeto, incremento o número de instâncias
        Imovel.numInstancias++;
    }

}

public class Locacao //Classe Locação
{

    public static void Alugar(Imovel imovel)
    {
        if (imovel.Alugado == false)
        {
            imovel.Alugado = true;
        }
    }

}

class Program //Classe de execução 
{
    public static void Main(string[] args)
    {
        Imovel meuImovel = new Imovel();
        meuImovel.Endereco = "Rua Engenheiro Stevaux 1";
        meuImovel.NumSuites = 1;
        meuImovel.Metragem = 100;

        Imovel meuImovel2 = new Imovel(3); //Objeto 2, convocando o segundo construtor. 

        //Chamo o construtor que recebe 1 parâmetro e passo mais parâmetros
        Imovel meuImovel3 = new Imovel(5)
        {
            Metragem = 50,
            NumSuites = 3,
            Endereco = "Rua do Imovel 3"
        };

        Imovel novoImovel = new Imovel();


        Imovel novoImovel2 = new Imovel(2)
        {
            Metragem = 200,
            NumSuites = 1,
            Endereco = "Rua do Senac"
        };

        Console.WriteLine("Metragem do Imovel 2 : " + novoImovel2.Metragem);


        Console.WriteLine("Status:" + novoImovel.Alugado);

        Locacao.Alugar(novoImovel);

        Console.WriteLine("Novo Status:" + novoImovel.Alugado);

        Console.WriteLine("Instancias criadas: " + Imovel.GetNumInstancias());

        Console.WriteLine("Construtora: " + Imovel.GetNomeIncorporadora());

        Console.WriteLine("Imóvel 1 - cômodos: " + meuImovel.GetNumComodos());
        Console.WriteLine("Imóvel 2 - cômodos: " + meuImovel2.GetNumComodos());
        // Console.WriteLine("Imóvel 3 - cômodos: " + meuImovel3.GetNumComodos() + "\n");

        //     Console.WriteLine("Instâncias criadas: " + Imovel.GetNumInstancias() + "\n");

        //     //Realizo a locação do imóvel
        //     Locacao.Alugar(meuImovel);
        //     Console.WriteLine("-----------------\n");
        //     Console.WriteLine("Imóvel 1\nEndereço: " + meuImovel.Endereco + "\nLocado: " + meuImovel.Alugado);
    }
}