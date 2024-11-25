namespace LivrariaKultura.Models;

public abstract class Produto
{
    public uint Id { get; set; } = 0;
    public string Nome { get; set; } = string.Empty;
    public decimal Preco { get; set; } = 0.00m;
    public string Descricao { get; set; } = string.Empty;
    public uint QuantidadeEstoque { get; set; } = 0;
    public bool IsEmPromocao { get; set; } = false;
    public Categoria? Categoria { get; set; } = null;
    
    protected virtual decimal TaxaDesconto { get; } = 0.05m;
    protected virtual decimal TaxaImposto { get; } = 0.07m;

    public virtual decimal CalcularImposto()
    {
        return Preco * TaxaImposto;
    }

    public virtual decimal AplicarDesconto()
    {
        if (!IsEmPromocao)
        {
            return Preco;
        }
        
        return Preco - Preco * TaxaDesconto;
    }
}