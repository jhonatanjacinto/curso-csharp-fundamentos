// Classe: é um molde que define as características que um determinado objeto terá
// Métodos: são os comportamentos que um objeto (ou a classe em si) podem ter
// Propriedades: são características que um objeto possui
// Objeto (Instância): é a representação concreta de algo no mundo real criado a partir das definições da sua classe base.

using OOP;

// Console.WriteLine("## Introdução a Orientação a Objetos ##");

// var produto1 = new Produto(22, "Arroz Tio João", "Minha descrição 1");
// //
// var produto2 = new Produto()
// {
//     Id = 2,
//     Nome = "Feijão Camil",
//     Preco = 15.00m
// };
// //
// var produto3 = new Produto("Açúcar União")
// {
//     Id = 3,
//     Preco = 10.00m
// };

//
// var produto4 = new Produto();
// produto4.ExibirCategorias("Alimentos", "Frios");
//
// Console.WriteLine($"O valor padrão de desconto é: {Produto.Desconto}");
// Console.WriteLine($"Valor do Produto 1 aplicado desconto: {produto1.AplicarDesconto()}");
// Console.WriteLine($"Valor do Produto 2 aplicado desconto: {Produto.AplicarDesconto(produto2.Preco)}");
// Console.WriteLine($"Valor do Produto 2 aplicado desconto: {Produto.AplicarDesconto(produto2.Preco, 0.15m)}");

//
// Console.WriteLine("### Passagem de argumento por referencia e por valor ###");
//
// int x = 5;
// var y = Calculadora.DobraValor(x);
//
// Console.WriteLine($"O valor de X é: {x}"); // 5
// Console.WriteLine($"O valor de Y é: {y}"); // 10
// Console.WriteLine();
//
// Calculadora.DobraValor(ref x);
//
// Console.WriteLine($"O valor de X é: {x}"); // 10
// Console.WriteLine($"O valor de Y é: {y}"); // 10
// Console.WriteLine();
//
// Calculadora.DobraValor(x, out y);
//
// Console.WriteLine($"O valor de X é: {x}"); // 10
// Console.WriteLine($"O valor de Y é: {y}"); // 20
//
// Console.WriteLine();

// var onibus1 = new Onibus()
// {
//     Codigo = 2251,
//     Marca = "Caio",
//     Modelo = "Apache Vip5"
// };
//
// var onibus2 = new Onibus()
// {
//     Codigo = 332,
//     Marca = "Marcopolo",
//     Modelo = "Torino"
// };
//
// Onibus.Empresa = "ETT Carapicuíba";
// Onibus.Linhas.Add("Jd. Santa Brigida");
//
// Console.WriteLine($"A lista de linhas disponíveis para Onibus1: {string.Join(", ", onibus1.GetLinhas())}");
// Console.WriteLine($"A lista de linhas disponíveis para Onibus2: {string.Join(", ", onibus2.GetLinhas())}");
// Console.WriteLine($"Empresa: {onibus1.GetEmpresa()}");
// Console.WriteLine($"Empresa: {onibus2.GetEmpresa()}");

// var animal0 = new Animal();
//
// var animal1 = new Gato()
// {
//     Genero = "Fêmea"
// };
//
// animal1.Andar();
// animal1.Pular();
// animal1.Comer();
// animal1.Miar();
// animal1.Correr();
//
// var animal2 = new Papagaio()
// {
//   Genero = "Macho"
// };
//
// animal2.Andar();
// animal2.Pular();
// animal2.Comer();
// animal2.Voar();
//
// Console.WriteLine($"A espécie de animal2 é: {animal2.Especie}");

// UsuarioAdmin u2 = new();
// u2.Login();
//
// Usuario u3 = new UsuarioAdmin();
// u3.Login();
// u3.Logout();
var p = new Papagaio();
p.Andar();
FazerVoar(p);

var p2 = new Passarinho();
FazerVoar(p2);

var h = new Helicoptero();
FazerVoar(h);

var b = new Borboleta();
FazerVoar(b);
void FazerVoar(IVoavel obj)
{
    // obj tem que poder voar (.Voar())
    obj.Voar();
}