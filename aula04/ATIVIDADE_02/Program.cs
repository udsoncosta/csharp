using System.Runtime.Intrinsics.X86;

namespace ATIVIDADE_02
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 1, menor21 = 0, maior50 = 0;

            while (idade > 0)
            {
                Console.Write("Digite a sua idade: ");
                idade = Convert.ToInt32(Console.ReadLine());

                if (idade > 0 && idade < 21) menor21++;
                if (idade > 50) maior50++;
             
            }

                Console.WriteLine($"Total de pessoas com idade menor que 21 anos: {menor21}");
                Console.WriteLine($"Total de pessoas com idade maior que 50 anos: {maior50}");
        }
      }
          }




    
