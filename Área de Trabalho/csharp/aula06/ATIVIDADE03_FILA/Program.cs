namespace ATIVIDADE03_FILA
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();
            int opcao;

            do
            {
                Console.WriteLine("***************************************************");
                Console.WriteLine("* 1 - Adicionar cliente na fila                   *");
                Console.WriteLine("* 2 - Listar clientes na fila                     *");
                Console.WriteLine("* 3 - Chamar cliente da fila                      *");
                Console.WriteLine("* 0 - Sair                                        *");
                Console.WriteLine("***************************************************");
                Console.Write("Entre com a opção desejada: ");

                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Console.Write("Digite o nome do cliente: ");
                        string nome = Console.ReadLine();
                        fila.Enqueue(nome);
                        Console.WriteLine("Cliente adicionado!");
                        break;

                    case 2:
                        Console.WriteLine("Clientes na fila:");
                        foreach (string cliente in fila)
                        {
                            Console.WriteLine(cliente);
                        }
                        break;

                    case 3:
                        if (fila.Count == 0)
                        {
                           
                          Console.WriteLine("A fila está vazia!");
                        }
                        else
                        {
                            fila.Dequeue();
                            foreach (string cliente in fila)
                            {
                                Console.WriteLine("A fila está vazia!");
                            }
                           
                        }
                        break;

                        default:
                        Console.WriteLine("Programa finalizado");
                        break;
                }

                Console.WriteLine();
            } while (opcao != 0);
        }
    }
}