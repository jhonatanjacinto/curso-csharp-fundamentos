namespace OOP;

public class Gato : Animal
{
    public Gato()
    {
        Nome = "Gato";
        Especie = "Felino";
        Olhos = 2;
    }
    public void Miar() => Console.WriteLine($"O animal {Nome} está miando...");
    public void Correr() => Console.WriteLine($"O animal {Nome} está correndo...");
}