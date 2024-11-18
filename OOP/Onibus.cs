namespace OOP;

public class Onibus
{
    public int Codigo { get; set; }
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Motorista { get; set; }
    public int Rodas { get; set; } = 4;
    public static string Empresa = "DelRey Transportes";
    public static List<string> Linhas { get; set; } = [
        "Vila Dirce", "Vila Marcondes", "Jd. São Daniel"
    ];

    public List<string> GetLinhas() => Linhas;
    public string GetEmpresa() => Empresa;
}