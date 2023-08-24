namespace Atividade_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroA, numeroB, numeroC, soma;

            
            Console.WriteLine($"\nDigite um valor para A: ");
            numeroA = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nDigite um valor para B: ");
            numeroB = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nDigite um valor para C: ");
            numeroC = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"\nA soma de {numeroA} + {numeroB} é: " + (numeroA + numeroB));

            soma = numeroA + numeroB;

            if (numeroA + numeroB > numeroC)
            {
                Console.WriteLine($"\nA soma dos números A e B é maior do que o número C");
            }
            else if (soma == numeroC)
            {
                Console.WriteLine($"\nA soma dos números A e B é igual ao número C");
            }
             else
            {
                Console.WriteLine($"\nA soma dos números A e B é menor do que o número C");
            }
        }
    }
}