namespace OOP;

public class Ave : Animal, IVoavel
{
   public virtual void Voar() => Console.WriteLine($"O animal {Nome} está voando...");
}