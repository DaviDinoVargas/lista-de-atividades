namespace Exercicio20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escrever um algoritmo que leia um valor para uma variável N de 1 a 10 e calcule a tabuada de N.
            while (true)
            {
                Console.Clear();
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("           GERADOR DE TABUADA (1 a 10) ");
                Console.WriteLine("          Digite um número entre 1 e 10: ");
                Console.WriteLine("_________________________________________________");
                string entrada = Console.ReadLine()!;

                if (int.TryParse(entrada, out int n) && n >= 1 && n <= 10)
                {
                    Console.WriteLine("_________________________________________________");
                    Console.WriteLine($"          Tabuada do {n}");
                    Console.WriteLine("_________________________________________________");

                    for (int i = 0; i <= 10; i++)
                    {
                        Console.WriteLine($"{i} x {n} = {i * n}");
                    }

                    Console.WriteLine("_________________________________________________\n");
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
