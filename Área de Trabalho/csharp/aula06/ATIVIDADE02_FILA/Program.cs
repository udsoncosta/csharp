namespace Atividade_01___Estrutura_de_Dados
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

                Console.WriteLine("\n***********************************************");
                Console.WriteLine("  1 - Adicionar um novo Cliente na fila  ");
                Console.WriteLine("  2 - Listar todos os Clientes na fila   ");
                Console.WriteLine("  3 - Chamar (retirar) Cliente da fila   ");
                Console.WriteLine("  0 - Sair   ");
                Console.WriteLine("***********************************************");
                Console.WriteLine("Entre com a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("\nDigite o nome que deseja adicionar: \n");
                        nome = Console.ReadLine();
                        fila.Enqueue(nome);
                        Console.WriteLine("\nCliente Adicionado!\n");

                        break;
                    case 2:
                        Console.WriteLine("\nLista de Clientes na Fila: \n");
                        foreach (var nomeFor in fila)
                        {
                            Console.WriteLine(nomeFor);
                        }
                        break;
                    case 3:
                        Console.WriteLine("\nNa Fila: \n");
                        if (fila.Count == 0)
                        {
                            Console.WriteLine("\nA Fila está vazia!\n");
                        }
                        else
                        {
                            fila.Dequeue();
                            foreach (var nomeFor in fila)
                            {
                                Console.WriteLine(nomeFor);
                            }
                            Console.WriteLine("\nO Cliente foi Chamado!\n");
                        }
                        break;
                    default:
                        Console.WriteLine("\nPrograma Finalizado!");
                        break;

                }




            }
        }
    }
}