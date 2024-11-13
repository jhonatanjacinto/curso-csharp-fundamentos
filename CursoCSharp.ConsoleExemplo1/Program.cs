while (true)
{
    Console.Clear();
    Console.WriteLine("## Calculadora de IMC ##");
    Console.WriteLine();
    
    Console.WriteLine("Informe o peso:");
    if (!double.TryParse(Console.ReadLine(), out var peso) || peso <= 0)
    {
        LimparConsole("Peso informado é inválido!");
        continue;
    }
    
    Console.WriteLine("Informe sua altura:");
    if (!double.TryParse(Console.ReadLine(), out var altura) || altura <= 0)
    {
        LimparConsole("Altura informada é inválida!");
        continue;
    }

    // Calcular o IMC
    var imc = peso / (altura * altura);

    Console.WriteLine($"Seu IMC é: {imc}");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Gostaria de realizar um novo cálculo? S = Sim / N = Não");
    Console.ResetColor();
    var tecla = Console.ReadKey();

    switch (tecla.Key)
    {
        case ConsoleKey.S:
            continue;
        case ConsoleKey.N:
            return;
        default:
            LimparConsole("Opção selecionada é inválida! O programa será terminado.");
            return;
    }
}

void LimparConsole(string mensagem)
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(mensagem);
    Console.ResetColor();
    Console.ReadKey();
}
