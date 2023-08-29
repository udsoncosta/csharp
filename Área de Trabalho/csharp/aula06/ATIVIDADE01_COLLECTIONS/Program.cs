namespace ColorCollectionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coresN = new List<string>();

            Console.WriteLine("Digite o nome de 5 cores:");

            for (int i = 0; i < 5; i++)
            { 
                string color = Console.ReadLine();
                coresN.Add(color);
            }

            Console.WriteLine("\nAs cores adicionadas foram:");
            foreach (string cores in coresN)
            {
                Console.WriteLine(cores);
            }

            coresN.Sort();

            Console.WriteLine("\nCores em ordem crescente:");
            foreach (string color in coresN)
            {
                Console.WriteLine(color);
            }
        }
    }
}
