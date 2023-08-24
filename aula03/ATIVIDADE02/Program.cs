namespace ATIVIDADE02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Digite um número");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 0 && num % 2 == 0)
            {
                Console.WriteLine($"\nO numéro {num} é negativo e par!");
            }
            else if (num > 0 && num % 2 == 0)
            {
                Console.WriteLine($"\nO numéro {num} é positivo e par!");
            }
            else if (num < 0 && num % 2 == -1)
            {
                Console.WriteLine($"\nO numéro {num} é negativo e ímpar!");
            }
            else
            {
                Console.WriteLine($"\nO numéro {num} é positivo e ímpar!");
            }

        }
    }
}