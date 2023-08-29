namespace ATIVIDADE02_PILHA
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> livro = new Stack<string>();

            while (true)
            {
                Console.WriteLine("**************************************");
                Console.WriteLine("* 1 - Adicionar livro na pilha       *");
                Console.WriteLine("* 2 - Listar todos os livros         *");
                Console.WriteLine("* 3 - Retirar livro da pilha         *");
                Console.WriteLine("* 0 - Sair                           *");
                Console.WriteLine("**************************************");
                Console.Write("Entre com a opção desejada: ");

                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao) 
                {
                    case 1:
                        Console.Write("Digite o título do livro: ");
                        string titulo = Console.ReadLine();
                        livro.Push(titulo);
                        Console.WriteLine("Livro adicionado!");
                        break;

                    case 2:
                        if (livro.Push.Count == 0)
                        {
                            Console.WriteLine("A pilha de livros está vazia!");
                        }
                        else
                        {
                            Console.WriteLine("Livros na pilha:");
                            foreach (string livro in livro.Push)
                            {
                                Console.WriteLine(livro);
                            }
                        }
                        break;

                    case 3:
                        if (livro.Push.Count == 0)
                        {
                            Console.WriteLine("A pilha de livros está vazia!");
                        }
                        else
                        {
                            string livroRemovido = livro.Pop();
                            Console.WriteLine($"O livro '{livroRemovido}' foi retirado da pilha.");
                        }
                        break;

                    case 0:
                        Console.WriteLine("Programa finalizado.");
                        return;

                    default:
                        Console.WriteLine("Opção inválida! ");
                        break;
                }
            }
        }
    }
}