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
                bool entradaValida = false;
                Console.WriteLine("_________________________________________________________________________");
                Console.WriteLine("Insira o comprimento, altura e largura da caixa (separados por vírgula): ");
                Console.WriteLine("_________________________________________________________________________");
                string[] entrada = Console.ReadLine()!.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (entrada.Length == 3 &&
                    decimal.TryParse(entrada[0].Trim(), out comprimento) &&
                    decimal.TryParse(entrada[1].Trim(), out altura) &&
                    decimal.TryParse(entrada[2].Trim(), out largura))
                {
                    entradaValida = true;
                }
               
                if (!entradaValida)
                {
                    Console.WriteLine("Entrada inválida!");
                    continue;
                }

                decimal volume = comprimento * altura * largura;
                Console.WriteLine("_________________________________________________________________________");
                Console.WriteLine($"                  O volume da caixa é: {volume}cm³");
                Console.WriteLine("_________________________________________________________________________");


                Console.Write("Deseja continuar? (s/N): ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();
                if (opcaoContinuar != "S")
                    break;
            }
        }
    }
}

