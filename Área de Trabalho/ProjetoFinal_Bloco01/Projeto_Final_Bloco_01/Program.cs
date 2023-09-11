namespace Projeto_Final_Bloco_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao, tamanhoCalcado, id;
            string? nomeCliente, tipo, categoria, subcategoria, cor;
            decimal valor;

            while (true)
            {

                Console.BackgroundColor = ConsoleColor.DarkYellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine("                Calçados & Cia                       ");
                Console.WriteLine("                                                     ");
                Console.WriteLine("*****************************************************");
                Console.WriteLine("                                                     ");
                Console.WriteLine("       1 - Cadastrar Produto                         ");
                Console.WriteLine("       2 - Listar Todas os Produtos                  ");
                Console.WriteLine("       3 - Buscar Produto Pelo Id                    ");
                Console.WriteLine("       4 - Atualizar Produto                         ");
                Console.WriteLine("       5 - Remover Produto                           ");
                Console.WriteLine("       6 - Buscar Produto Pela Categoria             ");
                Console.WriteLine("       7 - Sair                                      ");
                Console.WriteLine("************************************************");
                Console.WriteLine("                                                ");
                Console.WriteLine("Entre com a opção desejada:                     ");
                Console.WriteLine("                                                ");


                try
                {
                    opcao = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Digite um valor inteiro entre 1 e 7.");
                    opcao = 0;
                }

                Console.ResetColor();
                //Console.Clear();

                if (opcao == 7)
                {
               
                    Console.WriteLine("***********************************************");
                    Console.WriteLine("         Obrigado e até breve!                 ");
                    Console.WriteLine("**********************************************\n");
                    Sobre();                   
                    System.Environment.Exit(0);
                }


                switch (opcao)
                {
                    case 01:

                        Console.WriteLine("\nCadastrar produto:\n");
                        break;
                    case 02:
                        

                        Console.WriteLine("\nListar todos os produtos:\n");
                        break;
                    case 03:
                      

                        Console.WriteLine("\nBuscar produto pelo Id: \n");
                        break;
                    case 04:
                        

                        Console.WriteLine("\nAtualizar produto: \n");
                        break;
                    case 05:
                        Console.ResetColor();
                        

                        Console.WriteLine("\nRemover produto: \n");
                        break;
                    case 06:
                       

                        Console.WriteLine("\nBuscar produto pela categoria: \n");
                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.WriteLine("\nOpção Inválida\n");
                        break;
                }
            }
        }
        static void Sobre()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("                                                    ");
            Console.WriteLine("      Projeto desenvolvido por Udson Costa          ");
            Console.WriteLine("  e-mail: udsoncostasantana@gmail.com@gmail.com     ");
            Console.WriteLine("         Github: github.com/udsoncosta              ");
            Console.WriteLine("                                                    ");
            Console.WriteLine("****************************************************");
        }
    }
    }
}