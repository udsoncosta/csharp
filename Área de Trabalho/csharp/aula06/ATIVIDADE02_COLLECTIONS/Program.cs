using System;

namespace ATIVIDADE02_COLLECTIONS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> setNum = new HashSet<int>()
            {
            };
            int num;


            for (int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine($"Digite um número inteiro:");
                num = Convert.ToInt32(Console.ReadLine());
                setNum.Add(num);
            }

            Console.WriteLine($"\nListar dados do HashSet:");
            foreach (var numero in setNum)
            {
                Console.WriteLine(numero);
            }
        }
    }
}