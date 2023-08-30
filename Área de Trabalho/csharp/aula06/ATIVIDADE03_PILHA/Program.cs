namespace ATIVIDADE03_PILHA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack<string> pilha = new Stack<string>();
            int opcao = 1;
            string? titulo;

            while (opcao > 0 && opcao < 4)
            {

                Console.WriteLine("*************************************************");
                Console.WriteLine("*  1 - Adicionar novo livro na pilha            *");
                Console.WriteLine("*  2 - Listar todos os livros                   *");
                Console.WriteLine("*  3 - Retirar um livro da pilha                *");
                Console.WriteLine("*  0 - Sair                                     *");
                Console.WriteLine("*************************************************");
                Console.WriteLine("Entre com a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:

                        Console.WriteLine("Digite o titulo: ");
                        titulo = Console.ReadLine();
                        pilha.Push(titulo);
                        Console.WriteLine("Livro adicionado!");

                        break;
                    case 2:
                        Console.WriteLine("Lista de livros na Pilha: ");
                        foreach (var nome in pilha)
                        {
                            Console.WriteLine(nome);
                        }
                        break;
                    case 3:
                        
                        if (pilha.Count == 0)
                        {
                            Console.WriteLine("A pilha está vazia!");
                        }
                        else
                        {
                            pilha.Pop();
                            foreach (var nomeFor in pilha)
                            {
                                Console.WriteLine(nomeFor);
                            }
                            Console.WriteLine("O livro foi removido com sucesso!");
                        }
                        break;
                    default:
                        Console.WriteLine("Programa finalizado!");
                        break;

                }
                if (opcao == 0)
                {
                    Console.WriteLine("Programa finalizado!");
                }
                
                }
            }
        }
    }
