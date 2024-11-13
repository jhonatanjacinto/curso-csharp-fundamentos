int valor1 = 5;

/*
 * O bloco unsafe permite que você escreva código C# que pode
 * alterar características do gerenciamento da aplicação (em especial a memória)
 * de forma direta (quase como um acesso de baixo nível, como feito em linguagens tipo C, C++).
 * Então, tenha cuidado com o que você faz aqui.
 */
unsafe
{
    // valor2 é um ponteiro de inteiro para o endereço de memória da variável valor1
    int* valor2 = &valor1;
    *valor2 = 10;

    Console.WriteLine($"Valor 1: 0x{((long)&valor1):X}");
    Console.WriteLine($"Valor 2: 0x{((long)valor2):X}");
}

// Float, Double e Decimal
// float valorFloat = 10.5f;
// double valorDouble = 10.5;
// decimal valorDecimal = 10.5m;
//
// float calculo1 = (float) 1 / 3;
// double calculo2 = (double) 1 / 3;
// decimal calculo3 = (decimal) 1 / 3;
//
// Console.WriteLine("Digite um valor numérico com casas decimais: ");
// var statusConversao = float.TryParse(Console.ReadLine(), out var valor);
// if (statusConversao == false)
// {
//     Console.WriteLine("Não foi possível realizar a conversão do valor!");
//     return;
// }
//
// Console.WriteLine($"Valor Convertido: {valor}");

// Console.WriteLine($"Valor Float: {valorFloat}");
// Console.WriteLine($"Valor Double: {valorDouble}");
// Console.WriteLine($"Valor Decimal: {valorDecimal}");
// Console.WriteLine();
//
// Console.WriteLine($"Cálculo 1: {calculo1}");
// Console.WriteLine($"Cálculo 2: {calculo2}");
// Console.WriteLine($"Cálculo 3: {calculo3}");

dynamic nome = 56;
nome = nome.ToUpper();

Console.WriteLine(nome);

