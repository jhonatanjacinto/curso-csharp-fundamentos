using System.Threading.Channels;

namespace OOP;

public class Produto
{
    // propriedades de um produto
    public uint Id = 0;
    public string Nome = string.Empty;
    public string Descricao = string.Empty;
    public decimal Preco = 0m;
    public string Categoria = string.Empty;
    
    // métodos do produto
    public decimal AplicarDesconto()
    {
        return this.Preco - (this.Preco * 0.05m);
    }
}