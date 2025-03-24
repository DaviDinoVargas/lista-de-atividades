namespace Exercicio18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("_________________________________________________");
            Console.WriteLine("   Números ímpares entre 100 e 200:");
            Console.WriteLine("_________________________________________________");

            for (int i = 101; i < 200; i += 2)
            {
                Console.Write($"{i} ");
            }

            Console.WriteLine("\n_________________________________________________");
            Console.ReadLine();
        }
    }
}