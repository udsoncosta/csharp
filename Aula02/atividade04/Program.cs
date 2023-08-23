namespace atividade04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float n1, n2, n3, n4, diferença;

            Console.WriteLine("Digite o primeiro número: ");
            n1 = Convert.ToSingle (Console.ReadLine());
            Console.WriteLine("Digite o segundo número:");
            n2 =Convert.ToSingle (Console.ReadLine());
            Console.WriteLine("Digite o terceiro número: ");
            n3 =Convert.ToSingle (Console.ReadLine());
            Console.WriteLine("Digite o quarto número: ");
            n4 =Convert.ToSingle (Console.ReadLine());

            diferença = (n1 * n2) - (n3 * n4);

            Console.WriteLine("A diferneça é:" + diferença);

            



        }
    }
}