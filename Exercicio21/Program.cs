namespace Exercicio21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo que leia um valor inicial A e imprima a sequência de valores do cálculo de A! e o seu resultado.
            while (true)
            {
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("                FATORIAL N! ");
                Console.WriteLine("_________________________________________________");

                Console.Write("Digite um número inteiro positivo: ");
                string entrada = Console.ReadLine()!;

                if (int.TryParse(entrada, out int a) && a >= 0)
                {
                    long fatorial = 1;
                    Console.Write($"{a}! = ");

                    for (int i = a; i > 0; i--)
                    {
                        fatorial *= i;
                        Console.Write(i + (i > 1 ? " x " : " = "));
                    }

                    Console.WriteLine(fatorial);
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