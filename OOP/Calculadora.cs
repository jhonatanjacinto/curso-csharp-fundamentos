namespace OOP;

public static class Calculadora
{
    public static int DobraValor(int valor)
    {
        valor *= 2;
        Console.WriteLine($"O valor dobrado é: {valor}");
        return valor;
    }

    public static void DobraValor(ref int valor)
    {
        valor *= 2;
        Console.WriteLine($"O valor dobrado é: {valor}");
    }

    public static void DobraValor(int valor, out int resultado)
    {
        resultado = valor * 2;
        Console.WriteLine($"O valor dobrado é: {resultado}");
    }
}