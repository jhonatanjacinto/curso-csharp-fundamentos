namespace OOP;

public class Produto
{
    public uint Id { get; set; } = 0;
    public string Nome { get; set; } = string.Empty;
    public string Descricao { get; set; } = string.Empty;

    // Sobrecarga de Construtor (Constructor Overloading) 
    public Produto()
    {
        
    }

    public Produto(string nome) => Nome = nome;
    
    public Produto(uint id, string nome, string descricao) : this(nome)
    {
        Id = id;
        Descricao = descricao;
    }

    public decimal Preco
    {
        get; 
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Preço Inválido!");
            }
            field = value;
        }
    }
    public string Categoria { get; set; } = string.Empty;
    public const decimal Desconto = 0.05m;

    // Sobrecarga de Métodos (Method Overloading)
    public decimal AplicarDesconto() => Preco - (Preco * Desconto);

    public static decimal AplicarDesconto(decimal preco) => preco - (preco * Desconto);
    public static decimal AplicarDesconto(decimal preco, decimal percentual) => preco - (preco * percentual);

    public void ExibirCategorias(params string[] categorias)
    {
        Console.WriteLine(string.Join(", ", categorias));
    }
}