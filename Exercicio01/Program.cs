using System.Drawing;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crie um programa para calcular o volume de uma caixa retangular
            while (true)
            {
                decimal comprimento = 0, altura = 0, largura = 0;
                Console.Clear();
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("              _____________________");
                Console.WriteLine("             /                    /|");
                Console.WriteLine("            /                    / |");
                Console.WriteLine("           /                    /  |");
                Console.WriteLine("          /                    /   |");
                Console.WriteLine("         /____________________/    |");
                Console.WriteLine("         |                    |    |");
                Console.WriteLine("         |                    |    |");
                Console.WriteLine("         |                    |    /");
                Console.WriteLine("         |                    |   /");
                Console.WriteLine("         |                    |  /");  
                Console.WriteLine("         |                    | /");
                Console.WriteLine("         |____________________|/");
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("Insira o comprimento, altura e largura da caixa: ");
                Console.WriteLine("_________________________________________________\n");
                string[] entrada = Console.ReadLine()!.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (entrada.Length == 3 &&
                    decimal.TryParse(entrada[0].Trim(), out comprimento) &&
                    decimal.TryParse(entrada[1].Trim(), out altura) &&
                    decimal.TryParse(entrada[2].Trim(), out largura))
                {
                    decimal volume = comprimento * altura * largura;
                    Console.WriteLine("_________________________________________________");
                    Console.WriteLine($"        O volume da caixa é: {volume}cm³");
                    Console.WriteLine("_________________________________________________");
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Aperte <ENTER> e tente novamente!");
                    Console.ReadLine();
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

