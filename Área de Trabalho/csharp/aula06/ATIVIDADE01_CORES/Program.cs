namespace ATIVIDADE01_CORES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> coresNew = new List<string>();
            string? cores;


            for (int contador = 0; contador < 5; contador++)
            {
                Console.WriteLine("Digite o nome de 5 cores: ");
                cores = Console.ReadLine();
                coresNew.Add(cores);
            }

            Console.WriteLine("\nListar todas as cores:\n");
            foreach (string cor in coresNew)
            {
                Console.WriteLine(cor);
            }
            coresNew.Sort();
            Console.WriteLine("\nOrdenar as cores por ordem crescente:");
            foreach (string cor in coresNew)
            {
                Console.WriteLine(cor);
            }

        }
    }
}