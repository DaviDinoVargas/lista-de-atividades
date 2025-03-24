namespace Exercicio22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("         SEQUÊNCIA DE FIBONACCI ");
                Console.WriteLine("_________________________________________________");

                Console.Write("Digite um número inteiro positivo: ");
                string entrada = Console.ReadLine()!;

                if (int.TryParse(entrada, out int n) && n >= 0)
                {
                    int a = 0, b = 1, fibo;
                    Console.WriteLine($"Sequência de Fibonacci até {n}:");

                    Console.Write(a);
                    if (n > 0) Console.Write($" {b}");

                    while (b <= n)
                    {
                        fibo = a + b;
                        if (fibo > n) break;
                        Console.Write($" {fibo}");
                        a = b;
                        b = fibo;
                    }

                    Console.WriteLine("\n_________________________________________________\n");
                }
                else
                {
                    Console.WriteLine("Entrada inválida!");
                    continue;
                }

                Console.Write("Deseja continuar? (s/N): ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();
                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
       
