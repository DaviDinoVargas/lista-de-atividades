namespace Exercicio15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double peso, altura;

            while (true)
            {
                Console.WriteLine("_________________________________________________");
                Console.WriteLine("  Informe seu peso e altura para calcular o IMC");
                Console.WriteLine("_________________________________________________\n");

                Console.Write("Informe seu peso (kg) e altura (metros): ");
                string[] entrada = Console.ReadLine()!.Split(new char[] {' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (entrada.Length == 2 &&
                    double.TryParse(entrada[0].Trim(), out peso) &&
                    double.TryParse(entrada[1].Trim(), out altura) &&
                    peso > 0 && altura > 0)
                {

                    double imc = peso / (altura * altura);

                    Console.WriteLine("_________________________________________________");
                    Console.WriteLine($"Seu IMC é: {imc:F2}");
                    Console.WriteLine("_________________________________________________\n");

                    if (imc < 18.5)
                    {
                        Console.WriteLine("Condição: Abaixo do peso");
                    }
                    else if (imc >= 18.5 && imc < 25)
                    {
                        Console.WriteLine("Condição: Peso normal");
                    }
                    else if (imc >= 25 && imc < 30)
                    {
                        Console.WriteLine("Condição: Acima do peso");
                    }
                    else
                    {
                        Console.WriteLine("Condição: Obeso");
                    }
                }
                else
                {
                    Console.WriteLine("Entrada inválida, adicione dois valores");
                    continue;
                }

                Console.Write("Deseja continuar? (s/N): ");
                string opcaoContinuar = Console.ReadLine()!.ToUpper();
                if (opcaoContinuar != "S")
                    break;
            }

            Console.WriteLine("_________________________________________________");
        }
    }
}