using System.Runtime.ConstrainedExecution;

namespace Exercicio12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Faça um algoritmo para ler o salário de um funcionário e aumentá-lo em 15 %.Após o aumento, desconte 8 % de
            // impostos.Imprima o salário inicial, o salário com o aumento e o salário final.
            while (true)
            {
                Console.Clear();
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("             Insira o Salário");
                Console.WriteLine("_________________________________________________\n");
                if (double.TryParse(Console.ReadLine(), out double salario) && salario > 0)
                {
                    double aumento = salario * 1.15;
                    double imposto = aumento * 0.08;
                    double salarioFinal = aumento - imposto;

                    Console.WriteLine("_________________________________________________");
                    Console.WriteLine($"      Seu salário é de R${salario}");
                    Console.WriteLine($"      Seu novo salário é de R${aumento:F2}");
                    Console.WriteLine($"      Imposto pago é de R${imposto:F2}");
                    Console.WriteLine($"      Resultando em: R${salarioFinal:F2}");
                    Console.WriteLine("_________________________________________________\n");

                    Console.Write("Deseja continuar? (s/N): ");
                    string opcaoContinuar = Console.ReadLine()!.ToUpper();
                    if (opcaoContinuar != "S")
                        break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida!");
                }
            }
        }
    }
}