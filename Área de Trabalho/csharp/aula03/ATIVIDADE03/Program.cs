namespace ATIVIDADE03

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? codProduto = "";
            int comida, quantidade;
            float pedido = 0;

            Console.WriteLine($"Faça seu pedido: ");
            Console.WriteLine("\n1 - Cachorro Quente");
            Console.WriteLine("2 - X — Salada");
            Console.WriteLine("3 - X — Bacon");
            Console.WriteLine("4 - Bauru");
            Console.WriteLine("5 - Refrigerante");
            Console.WriteLine("6 - Suco de laranja");
            comida = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Escolha a quantidade desejada: ");
            quantidade = Convert.ToInt32(Console.ReadLine());



            switch (comida)
            {
                case 1:
                    pedido = (quantidade * 10);
                    codProduto = "Cachorro Quente";
                    break;
                case 2:
                    pedido = (quantidade * 15);
                    codProduto = "X — Salada";
                    break;
                case 3:
                    pedido = (quantidade * 18);
                    codProduto = "X — Bacon";
                    break;
                case 4:
                    pedido = (quantidade * 12);
                    codProduto = "Bauru";
                    break;
                case 5:
                    pedido = (quantidade * 8);
                    codProduto = "Refrigerante";
                    break;
                case 6:
                    pedido = (quantidade * 13);
                    codProduto = "Suco de laranja";
                    break;
                default:
                    Console.WriteLine("Pedido inválido!");
                    break;
            }
            Console.WriteLine($"\nO seu pedido é {quantidade} {codProduto} com o valor de R${pedido}");
        }
    }
}