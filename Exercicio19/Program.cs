namespace Exercicio19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Desenvolver um algoritmo que efetue a soma de todos os números ímpares que são múltiplos de três e que se
            //encontram no conjunto dos números de 1 até 500.
            int soma = 0;

            Console.WriteLine("_________________________________________________");
            Console.WriteLine("Soma dos números ímpares múltiplos de 3 de 1 a 500");
            Console.WriteLine("_________________________________________________");

            for (int i = 1; i <= 500; i += 2)
            {
                if (i % 3 == 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine($"A soma é de: {soma}");
            Console.WriteLine("_________________________________________________");
            Console.ReadLine();
        }
    }
}