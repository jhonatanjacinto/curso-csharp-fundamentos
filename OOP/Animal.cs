namespace OOP;

public class Animal
{
    public string Nome { get; protected set; }
    public string Especie { get; protected set; }
    public int Olhos { get; protected set; } = 2;
    public string Genero { get; set; }

    public void Andar() => Console.WriteLine($"O animal {Nome} está andando...");

    public void Pular() => Console.WriteLine($"O animal {Nome} está pulando...");

    public void Comer() => Console.WriteLine($"O animal {Nome} está comendo...");

    protected void ExecutarSistemaDigestivo()
    {
    }
}