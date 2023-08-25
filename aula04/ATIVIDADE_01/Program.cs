using System;

namespace MultiplesOf3And5
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Digite o primeiro número: ");
            num1 =Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 >= num2)
            {
                Console.WriteLine("Intervalo inválido. ");
            }
            else
            {
                Console.WriteLine("Números múltiplos de 3 e 5 no intervalo:");
                for (int i = num1; i <= num2; i++)
                {
                    if (i % 3 == 0 && i % 5 == 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
        }
    }
}