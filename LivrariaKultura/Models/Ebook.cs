using LivrariaKultura.Enums;

namespace LivrariaKultura.Models;

public class Ebook : Livro
{
    public EbookFormato Formato { get; set; } = EbookFormato.Epub;
    
    public override decimal AplicarDesconto()
    {
        if (Formato == EbookFormato.Pdf)
        {
            return Preco - Preco * .20m;
        }

        return base.AplicarDesconto();
    }
}