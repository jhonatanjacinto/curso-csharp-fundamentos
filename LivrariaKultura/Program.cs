
using LivrariaKultura.Enums;
using LivrariaKultura.Models;

List<Produto> produtos = new()
{
    new Bebida() { Nome = "Café au Lait", Preco = 8.00m, IsEmPromocao = false },
    new Ebook() { Nome = "Seguindo a Correnteza", Autor = "Agatha Christie", Preco = 50.00m, Formato = EbookFormato.Pdf, IsEmPromocao = true },
    new LivroFisico() { Nome = "O sol é para todos", Autor = "Harper Lee", Preco = 35.00m, IsEmPromocao = true },
    new LivroFisico() { Nome = "Learning Go", Editora = "O'Reilly", Preco = 160.00m, IsEmPromocao = true },
    new Papelaria() { Nome = "Caneta Tinteiro", Marca = "Bic", Preco = 15.00m, IsEmPromocao = true }
};

foreach (var produto in produtos)
{
    ExibirPrecoProduto(produto);
    ExibirImpostoProduto(produto);
    Console.WriteLine();
}


void ExibirPrecoProduto(Produto produto)
{
    // Se ele estiver em promoção, tenho que aplicar o desconto antes de exibir o preço
    var preco = produto.Preco;
    if (produto.IsEmPromocao)
    {
        preco = produto.AplicarDesconto();
    }
    
    // Exibir o nome do produto e o preço dele
    Console.WriteLine($"Produto \"{produto.Nome}\" custa: {preco:C}");
}

void ExibirImpostoProduto(Produto produto)
{
    var valorImposto = produto.CalcularImposto();
    Console.WriteLine($"Imposto do Produto \"{produto.Nome}\" é de: {valorImposto:C}");
}