namespace Teste_2
{
    public class Program
    {
        public void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (Fibonacci(num))
            {
                Console.WriteLine($"{num} pertence a sequência de fibonacci");
            }
            else
            {
                Console.WriteLine($"{num} não pertence a sequência de fibonacci");
            }
            
        }

        static bool Fibonacci(int n)
        {
            int a = 0;
            int b = 1;
            int aux = 0;

            while (a < n)
            {
                aux = a + b;
                a = b;
                b = aux;
            }

            return a == n;
        }
    }
}
