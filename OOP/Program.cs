// Classe: é um molde que define as características que um determinado objeto terá
// Métodos: são os comportamentos que um objeto (ou a classe em si) podem ter
// Propriedades: são características que um objeto possui
// Objeto (Instância): é a representação concreta de algo no mundo real criado a partir das definições da sua classe base.

using OOP;

Console.WriteLine("## Introdução a Orientação a Objetos ##");

// Objeto (instância) do tipo Produto
var produto1 = new Produto();
produto1.Id = 1;
produto1.Nome = "Arroz Tio João";
produto1.Descricao = "Arroz Tipo 1 Branco";
produto1.Preco = 100m;
produto1.Categoria = "Alimentos";

var produto2 = new Produto();
produto2.Id = 2;
produto2.Nome = "Feijão Camil";
produto2.Preco = 200m;

Console.WriteLine($"Produto 1: {produto1.Nome}");
Console.WriteLine($"Produto 2: {produto2.Nome}");
Console.WriteLine($"Produto 1 com Desconto: {produto1.AplicarDesconto()}");
Console.WriteLine($"Produto 2 com Desconto: {produto2.AplicarDesconto()}");