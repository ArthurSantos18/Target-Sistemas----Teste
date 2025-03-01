namespace Teste_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string teste = "Teste";

            string resultado = "";

            int inicio = 0;
            int fim = teste.Length;

            for (int i = teste.Length - 1; i >= 0; i--)
            {
                resultado += teste[i]; 
            }

            Console.WriteLine(resultado);

        }
    }
}
