using System.Diagnostics;

namespace OOP;

public abstract class Usuario
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Sobrenome { get; set; }
    public string Email { get; set; }
    public string Senha { get; set; }

    // virtual = pode ser sobrescrito na classe filha
    // public virtual void Login()
    // {
    //     Console.WriteLine("Implementa a lógica padrão de Login...");
    // }

    // Métodos abstratos não tem corpo, só assinatura
    // e precisam ser obrigatoriamente implementados nas classes-filha
    public abstract void Login();

    public void Logout()
    {
        Console.WriteLine("Implementa a lógica padrão de Logout...");
    }
}

public class UsuarioEditor : Usuario
{
    public bool IsAutorizadoEditarPost { get; set; } = false;
    public override void Login()
    {
        Console.WriteLine("Login do Usuário Editor");
    }
}

public class UsuarioLeitor : Usuario
{
    public bool IsInscrito { get; set; } = false;
    public override void Login()
    {
        Console.WriteLine("Login do Usuário Leitor");
    }
}

public class UsuarioAdmin : Usuario
{
    public bool IsAutorizadoExcluirAdmins { get; set; } = false;
    
    // override = sobrescreve o método que está definido na classe mãe
    public override void Login()
    {
        Console.WriteLine("Lógica de Login exclusiva do UsuarioAdmin");
    }
    
    public void ExcluirUsuario(int id)
    {
        Console.WriteLine("Exclui um usuário do sistema...");
    }
}