using System; // Biblioteca

class Apartamento // Classe e nome da classe. Entre as chaves principais, em amarelo, tudo que faz parte da classe.
{
    // Defino os atributos ou variáveis da classe, informações que podem ser alteradas.
    int numComodos = 0;
    int metragem = 0;
    // Construtor com o mesmo nome da classe apenas sem o prefixo "Class"
    public Apartamento() // é utilizado a palavra chave (Prefixo) public.
    {
        numComodos = 2;
        metragem = 100;
    }
    public int getMetragem() // Forma de acessar a informação por meio da função get
    {
        return this.metragem;
    }
}

class Imovel
{
    // Defino os atributos
    int numComodos = 0;
    int numSuites = 0;
    int metragem = 0;

    bool locado = false; // Variável booleana.

    // Propriedades
    public String Endereco { get; set; } // Diferente dos atributos, as propriedades podem ser alteradas.

    // Defino os construtores
    public Imovel()
    {
        this.numComodos = 1; // Esse limita que o imóvel deve ter pelo menos um cômodo
    }

    public Imovel(int numComodos) // Não limitando o número de cômodos
    {
        this.numComodos = numComodos;
    }

    public int getNumComodos()
    {
        return this.numComodos;
    }

    public void setNumComodos(int numComodos) // Método set que permite alterar o número de cômodos
    {
        this.numComodos = numComodos;
    }

    public bool locar() // Método para fazer locação
    {
        if (locado == false)
        {
            locado = true;
        }

        return locado;
    }
} // Fim da classe Imovel

class Program // Passando parâmetros para as classes preencher os objetos
{
    public static void Main(string[] args)
    {
        // Instancio um objeto da classe Imovel
        Imovel meuImovel = new Imovel(); // e construo um imóvel da classe Imovel
        // Exibo o número de cômodos
        int num_comodos = meuImovel.getNumComodos();
        Console.WriteLine($"Número de quartos inicial: {num_comodos}");

        // Altero o número de cômodos
        meuImovel.setNumComodos(3);

        num_comodos = meuImovel.getNumComodos();
        // Exibo o número de cômodos
        Console.WriteLine($"Número de quartos final: {num_comodos}");

        Console.WriteLine("Status alugado? " + meuImovel.locar());

        // Instancio um objeto da classe Apartamento
        Apartamento meuAp = new Apartamento();
        Console.WriteLine($"Metragem: " + meuAp.getMetragem());
    }
}