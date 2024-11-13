// Arrays: são listas de tipo e tamanho fixos (indices são sempre numéricos)
// Listas: são coleções de dados de tamanho variável e, na maioria das vezes, tipo fixo (indices são sempre numéricos)

using System.Collections;

string[] nomes = ["Jhonatan", "Ana", "Pedro", "Josy", "Água"];
Console.WriteLine($"Sua lista de nomes tem {nomes.Length} valores que são:");

foreach (var nome in nomes)
{
    Console.WriteLine(nome);
}

// Reajustar o tamanho do array
Array.Resize(ref nomes, 6);
nomes[5] = "Adriana";

Console.WriteLine("Lista de Nomes atualizada: " + string.Join(", ", nomes));

Array.Sort(nomes);
Console.WriteLine($"Lista de Nomes Ordenada de forma Crescente: {string.Join(", ", nomes)}");

// ArrayList é uma lista de valores de tipo dinâmico que pode crescer ou diminuir sem problemas
ArrayList listaLinguagens = new ArrayList()
{
    "C#",
    "PHP",
    "Ruby",
    "Java",
    "Go",
    5,
    true,
    'a'
};

listaLinguagens.Add(false);
listaLinguagens.Insert(1, "ColdFusion");
listaLinguagens.Remove("PHP");
listaLinguagens.RemoveAt(2);

Console.WriteLine($"Lista de linguagens de programação: {string.Join(", ", listaLinguagens.ToArray())}");

List<string> listaProdutos = ["Arroz", "Feijão", "Batata", "Macarrão"];
Console.WriteLine($"Lista de Produtos: {string.Join(", ", listaProdutos)}");