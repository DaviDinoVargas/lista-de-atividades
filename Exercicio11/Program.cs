using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Exercicio11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escreva um algoritmo para ler o nome e a idade de uma pessoa, e exibir quantos dias de vida ela possui.
            //Considere sempre anos completos, e que um ano possui 365 dias.Ex: uma pessoa com 19 anos possui 6935 dias
            //de vida; veja um exemplo de saída: MARIA, VOCÊ JÁ VIVEU 6935 DIAS.
            while (true)
            {
                int idade = 0;
                Random geradorDeNumeros = new Random();
                int porc = geradorDeNumeros.Next(1, 100);
                string nome;
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("             Insira nome e idade: ");
                Console.WriteLine("_________________________________________________\n");
                string[] entrada = Console.ReadLine()!.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (entrada.Length != 2)
                {
                    Console.WriteLine("Entrada inválida! Certifique-se de digitar um nome e um número.");
                    Console.WriteLine("Aperte <ENTER> e tente novamente!");
                    Console.ReadLine();
                    continue;
                }

                nome = entrada[0].Trim();

                if (int.TryParse(entrada[1].Trim(), out idade))
                {
                    int dias = idade * 365;
                    int acrescimo = (int)((porc / 100.0) * dias);
                    int final = dias + acrescimo;
                    Console.WriteLine("_________________________________________________");
                    Console.WriteLine($"   Seu nome é {nome} e você ja viveu {dias} dias.");
                    Console.WriteLine($"     Seu tempo de vida será total de {final}.");
                    Console.WriteLine($"     Você tem {acrescimo} dias restando");
                    Console.WriteLine("_________________________________________________\n");
                }
                else
                {
                    Console.WriteLine("Erro: O segundo valor deve ser um número válido.");
                    Console.WriteLine("Aperte <ENTER> e tente novamente!");
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
        
    

