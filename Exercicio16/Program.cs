namespace Exercicio16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("Informe um número para saber se é par ou ímpar:");
                Console.WriteLine("_________________________________________________");

                Console.Write("Digite um número: ");
                if (int.TryParse(Console.ReadLine(), out int numero))
                {
                    if (numero % 2 == 0)
                    {
                        Console.WriteLine("_________________________________________________");
                        Console.WriteLine("              O número é PAR.");
                        Console.WriteLine("_________________________________________________");
                    }
                    else
                    {
                        Console.WriteLine("_________________________________________________");
                        Console.WriteLine("             O número é ÍMPAR.");
                        Console.WriteLine("_________________________________________________");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida! Por favor, insira um número válido.");
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
 
