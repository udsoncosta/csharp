using System.ComponentModel.Design;
using System.Runtime.InteropServices.Marshalling;

namespace EXERCICIO_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] vetor01 = {3, 2, 1, 6, 5, 4, 9 ,8 ,10 ,7};
            int posicao;

            for (int indice = 0; indice < vetor01.Length; indice++)
            {
                Console.WriteLine(vetor01[indice]);
            }
            
            Console.WriteLine("\n");

            Console.WriteLine("Digite o número que você deseja encontrar: ");
            posicao = Convert.ToInt32(Console.ReadLine());

            if (Array.IndexOf(vetor01, posicao) !=-1)
            {
                Console.WriteLine($"O número {posicao} está localizado na posição : " + Array.IndexOf(vetor01, posicao));
            }

            else
            {
                Console.WriteLine($"O número {posicao} nao foi encontrado!");
            }















        }
    }
}