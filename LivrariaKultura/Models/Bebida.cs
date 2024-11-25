namespace LivrariaKultura.Models;

public class Bebida : Produto
{
    protected override decimal TaxaImposto { get; } = 0.10m;
    protected override decimal TaxaDesconto { get; } = 0.08m;
}