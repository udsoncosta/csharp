namespace ATIVIDADE_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero, soma = 0;

            do
            {
                Console.WriteLine("Digite um número: ");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    soma += numero;
                }

            } while (numero != 0);

            Console.WriteLine($"A soma dos números positivos é: {soma}");
        }
    }
}


