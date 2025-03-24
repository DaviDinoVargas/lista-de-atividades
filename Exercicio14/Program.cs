using System;

namespace Exercicio14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Escreva um algoritmo que leia três valores inteiros e diferentes e mostre-os em ordem decrescente.
            int a, b, c;

            while (true)
            {
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("   Digite três valores inteiros e diferentes");
                Console.WriteLine("_________________________________________________\n");
       
                Console.Write("Valor 1: ");
                if (!int.TryParse(Console.ReadLine(), out a))
                {
                    Console.WriteLine("Entrada inválida! Tente novamente.");
                    continue;
                }

                Console.Write("Valor 2: ");
                if (!int.TryParse(Console.ReadLine(), out b) || b == a)
                {
                    Console.WriteLine("Entrada inválida ou valor igual ao anterior! Tente novamente.");
                    continue;
                }

                Console.Write("Valor 3: ");
                if (!int.TryParse(Console.ReadLine(), out c) || c == a || c == b)
                {
                    Console.WriteLine("Entrada inválida ou valor igual aos anteriores! Tente novamente.");
                    continue;
                }

                int[] valores = { a, b, c };
                Array.Sort(valores);
                Array.Reverse(valores);

                Console.WriteLine("_________________________________________________");
                Console.WriteLine("       Valores em ordem decrescente:");
                Console.WriteLine("_________________________________________________");
                foreach (var valor in valores)
                {
                    Console.WriteLine($"   {valor}");
                }

                Console.Write("\nDeseja continuar? (s/N): ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();
                if (opcaoContinuar != "S") break;
            }
        }
    }
}
