namespace atividade02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            float n1, n2, n3, n4, mediaFinal;

            Console.WriteLine("Digite a primeira nota: ");
            n1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota: ");
            n2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota: ");
            n3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Digite a quarta nota: ");
            n4 = Convert.ToSingle(Console.ReadLine());

            mediaFinal = (n1 + n2 + n3 + n4) / 4;

            Console.WriteLine("A média final é:" + mediaFinal);
        }
    }
}