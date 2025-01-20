using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Newtonsoft.Json;

class Questao3
{
    public static void Executar()
    {
        string jsonPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "assets", "dados.json");
        string jsonContent = File.ReadAllText(jsonPath);


        var faturamentoMensal = JsonConvert.DeserializeObject<List<Faturamento>>(jsonContent);
        var valoresValidos = faturamentoMensal.Where(f => f.Valor > 0).Select(f => f.Valor).ToList();

        double menorFaturamento = valoresValidos.Min();
        double maiorFaturamento = valoresValidos.Max();
        double mediaFaturamento = valoresValidos.Average();

        int diasAcimaDaMedia = faturamentoMensal.Count(f => f.Valor > mediaFaturamento);

        Console.WriteLine($"Menor faturamento: R$ {menorFaturamento:F2}");
        Console.WriteLine($"Maior faturamento: R$ {maiorFaturamento:F2}");
        Console.WriteLine($"Dias com faturamento acima da média: {diasAcimaDaMedia}");
    }

    private class Faturamento
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }
}
