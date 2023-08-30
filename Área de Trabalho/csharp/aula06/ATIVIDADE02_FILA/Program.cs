namespace ATIVIDADE02_FILA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> fila = new Queue<string>();
            int opcao = 1;
            string? nome;

            while (opcao > 0 && opcao < 4)
            {

                Console.WriteLine("************************************************");
                Console.WriteLine("*  1 - Adicionar cliente na fila               *");
                Console.WriteLine("*  2 - Listar todos os clientes                *");
                Console.WriteLine("*  3 - Chamar cliente da fila                  *");
                Console.WriteLine("*  0 - Sair                                    *");
                Console.WriteLine("************************************************");
                Console.WriteLine("Entre com a opção desejada:");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Digite o nome: ");
                        nome = Console.ReadLine();
                        fila.Enqueue(nome);
                        Console.WriteLine("Cliente Adicionado!");

                        break;
                    case 2:
                        Console.WriteLine("Lista de clientes na Fila: ");
                        foreach (var nomeN in fila)
                        {
                            Console.WriteLine(nomeN);
                        }
                        break;
                    case 3:
                        Console.WriteLine("Clientes na fila: ");
                        if (fila.Count == 0)
                        {
                            Console.WriteLine("A fila está vazia!");
                        }
                        else
                        {
                            fila.Dequeue();
                            foreach (var nomeN in fila)
                            {
                                Console.WriteLine(nomeN);
                            }
                            Console.WriteLine("O cliente foi chamado!");
                        }
                        break;
                    default:
                        Console.WriteLine("Programa Finalizado!");
                        break;

                }




            }
        }
    }
}