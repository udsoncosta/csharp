﻿namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;

            
            Console.Write("Digite a tabuada:");
            numero = Convert.ToInt32(Console.ReadLine());

            for (int contador = 1; contador <= 10; contador++)
            {
                Console.WriteLine($"{numero} x {contador} = {numero * contador}");
            }
        }
    }
}