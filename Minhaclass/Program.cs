using System;

namespace Minhaclass
{
    class Program
    {
        static void Main(string[] args)
        {
            // Escrever as variáveis
            double num1 = 0;
            double num2 = 0;

            // Título
            Console.WriteLine("Calculadora");
            Console.WriteLine("----------------------------------");

            // 1º número
            Console.WriteLine("Digite um número e pressione Enter");
            num1 = Convert.ToDouble(Console.ReadLine());

            // 2º número
            Console.WriteLine("Digite outro número e pressione Enter");
            num2 = Convert.ToDouble(Console.ReadLine());

            // Perguntar a equaçao
            Console.WriteLine("Escolhe a forma geométrica");
            Console.WriteLine(""); // Deixar espaço
            Console.WriteLine("\t s - Sumar");
            Console.WriteLine("\t r - subtrair");
            Console.WriteLine("\t d - dividir");
            Console.WriteLine(""); // Deixar espaço
            Console.Write("Sua opção é? ");

            // Usar o switch para calcular a área
            switch (Console.ReadLine())
            {
                case "s":
                    Console.WriteLine($"Seu resultado: {num1} + {num2} = " + (num1 + num2));
                    break;

                case "r":
                    Console.WriteLine($"Seu resultado: {num1} - {num2} = " + (num1 - num2));
                    break;

                case "d":
                    Console.WriteLine($"Seu resultado: {num1} / {num2} = " + (num1 * num2));
                    break;
            }

            Console.ReadKey();
        }
    }
}
