using System.Globalization;

// System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
Console.WriteLine("### Datas e Horas ###");
Console.WriteLine();

DateTime dataPadrao = new();
DateTime dataEspecifica = new(2021, 10, 12);
Console.WriteLine($"Data Padrão: {dataPadrao}");
Console.WriteLine($"Data Específica: {dataEspecifica}");

DateTime dataHojeComHorario = DateTime.Now;
DateTime dataHoje = DateTime.Today;
Console.WriteLine($"Data de Hoje (com Horário): {dataHojeComHorario}");
Console.WriteLine($"Data de Hoje: {dataHoje}");

Console.WriteLine("## Formatações da Datas ##");
Console.WriteLine($"ToShortDateString: {dataHoje.ToShortDateString()}");
Console.WriteLine($"ToLongDateString: {dataHoje.ToLongDateString()}");

// Data daqui 3 semanas
DateTime dataDaqui3Semanas = dataHoje.AddDays(21);
Console.WriteLine($"Data daqui 3 semanas: {dataDaqui3Semanas.ToLongDateString()}");

// Conversão de String para DateTime
DateTime dataConvertida = DateTime.Parse("04/12/1991");
Console.WriteLine($"Data convertida: {dataConvertida.ToLongDateString()}");