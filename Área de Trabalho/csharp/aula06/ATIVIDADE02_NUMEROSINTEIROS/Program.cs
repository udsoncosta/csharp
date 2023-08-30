namespace ATIVIDADE02_NUMEROSINTEIROS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> numInt = new HashSet<int>()
            {
            };
            int num;


            for (int contador = 0; contador < 10; contador++)
            {
                Console.WriteLine("Digite um número: ");
                num = Convert.ToInt32(Console.ReadLine());
                numInt.Add(num);
            }

            Console.WriteLine($"\nListar dados do HashSet:");
            foreach (var numero in numInt)
            {
                Console.WriteLine(numero);
            }
        }
    }
}