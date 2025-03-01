namespace Teste_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string palavra = "Teste";

            string resultado = "";

            for (int i = palavra.Length - 1; i >= 0; i--)
            {
                resultado += palavra[i]; 
            }

            Console.WriteLine(resultado);

        }
    }
}
