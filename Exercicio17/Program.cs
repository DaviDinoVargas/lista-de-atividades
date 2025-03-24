using System.Runtime.Intrinsics.X86;

namespace Exercicio17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem iguais deverá se somar os dois, caso
            //contrário multiplique A por B.Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma
            //variável C e mostrar seu conteúdo na tela.

            while (true)
            {
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("       Informe dois números inteiros:");
                Console.WriteLine("_________________________________________________");
                Console.Write("Digite dois números: ");
                string[] entrada = Console.ReadLine()!.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (entrada.Length == 2 &&
                    int.TryParse(entrada[0].Trim(), out int a) &&
                    int.TryParse(entrada[1].Trim(), out int b))
                {
                    int c;
                    if (a == b)
                    {
                        c = a + b;
                        Console.WriteLine("_________________________________________________");
                        Console.WriteLine($"Os valores são iguais, soma: {a} + {b} = {c}");
                        Console.WriteLine("_________________________________________________");
                    }
                    else
                    {
                        c = a * b;
                        Console.WriteLine("_________________________________________________");
                        Console.WriteLine($"Os valores são diferentes, multiplicação: {a} x {b} = {c}");
                        Console.WriteLine("_________________________________________________");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida!");
                    continue;
                }
                Console.Write("\nDeseja continuar? (s/N): ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();
                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}
        
    

