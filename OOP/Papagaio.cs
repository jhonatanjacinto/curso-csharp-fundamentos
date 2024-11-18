namespace OOP;

public class Papagaio : Animal
{
    public Papagaio()
    {
        Nome = "Papagaio";
        Especie = "Ave";
        Olhos = 2;
        ExecutarSistemaDigestivo();
    }
    public void Voar() => Console.WriteLine($"O animal {Nome} está voando...");
    
}