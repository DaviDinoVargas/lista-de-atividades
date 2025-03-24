using static System.Reflection.Metadata.BlobBuilder;

namespace Exercicio13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C.
            while (true)
            {
                double a = 0, b = 0, c = 0;
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("       Insira os pães e as broas vendidas ");
                Console.WriteLine("_________________________________________________\n");
                string[] entrada = Console.ReadLine()!.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (entrada.Length == 3 &&
                double.TryParse(entrada[0].Trim(), out a) &&
                double.TryParse(entrada[1].Trim(), out b) &&
                double.TryParse(entrada[2].Trim(), out c))
                {
                    if (a + b > c)
                    {
                        Console.WriteLine("_________________________________________________");
                        Console.WriteLine($"          A + B É MAIOR DO QUE C");
                        Console.WriteLine("_________________________________________________\n");
                    }
                    else
                        Console.WriteLine("_________________________________________________\n");
                        Console.WriteLine($"         A + B É MENOR OU IGUAL A C");
                        Console.WriteLine("_________________________________________________\n");
                }
                else
                {
                    Console.WriteLine("Entrada inválida!");
                }
                Console.Write("Deseja continuar? (s/N): ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();
                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}