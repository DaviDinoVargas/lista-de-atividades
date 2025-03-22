namespace Exercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crie um programa para calcular o volume de um Cilindro
            decimal raio = 0, altura = 0;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("       Insira o raio e altura do cilindro: ");
                Console.WriteLine("_________________________________________________\n");
                string[] entrada = Console.ReadLine()!.Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (entrada.Length == 2 &&
                    decimal.TryParse(entrada[0].Trim(), out raio) &&
                    decimal.TryParse(entrada[1].Trim(), out altura))
                {
                    decimal volume = (decimal)Math.PI * (decimal)Math.Pow((double)raio, 2) * altura;
                    Console.WriteLine("_________________________________________________");
                    Console.WriteLine($"      O volume do cilindro é: {volume:F2}cm³");
                    Console.WriteLine("_________________________________________________\n");
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
