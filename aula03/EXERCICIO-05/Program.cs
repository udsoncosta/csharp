namespace EXERCICIO_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? palavra1, palavra2, palavra3;
            Console.WriteLine("Digite a primeira palvar: ");
            palavra1 = Console.ReadLine();

            Console.WriteLine("Digite a segunda palvar: ");
            palavra2 = Console.ReadLine();

            Console.WriteLine("Digite a terceira palvar: ");
            palavra3 = Console.ReadLine();

            if (palavra1 is not null && palavra2 is not null && palavra3 is not null)
            {
                // Verificando se é vertebrado ou invertebrado
                if (palavra1.Equals("vertebrado"))
                {
                    // Verificando se é ave ou mamífer
                    if (palavra2.Equals("ave"))
                    {
                        if (palavra3.Equals("carnívoro"))
                        {
                            Console.WriteLine("Águia");
                        }
                        else
                        {
                            Console.WriteLine("Pomba");
                        }

                    

                
            
        