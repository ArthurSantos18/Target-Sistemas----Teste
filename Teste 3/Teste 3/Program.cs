using System.Text.Json;

namespace Teste_3
{
    class FaturamentoDiario
    {
        public int dia { get; set; }
        public double valor { get; set; }
    }

    public class Program
    {
        static void Main(string[] args)
        {

            string caminho = "dados.json";
            string json = File.ReadAllText(caminho);

            List<FaturamentoDiario> faturamento = JsonSerializer.Deserialize<List<FaturamentoDiario>>(json).Where(f => f.valor > 0).ToList();
            
            double menor = faturamento.Min(f => f.valor);
            double maior = faturamento.Max(f => f.valor);

            double media = faturamento.Average(f => f.valor);
            int diasAcimadaMedia = faturamento.Count(f => f.valor > media);

            Console.WriteLine($"Menor faturamento: R$ {menor:F2}");
            Console.WriteLine($"Maior faturamento: R$ {maior:F2}");
            Console.WriteLine($"Media: R$ {media:F2}");
            Console.WriteLine($"Número de dias acima da média: {diasAcimadaMedia}");

        }
    }
}
