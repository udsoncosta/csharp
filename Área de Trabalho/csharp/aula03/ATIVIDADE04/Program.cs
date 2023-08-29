namespace ATIVIDADE04

{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome, cargoX = "";
            int cargo, salario;
            float aumento, reajuste = 0;

            Console.WriteLine("Digite seu nome: ");
            nome = Console.ReadLine();
            Console.WriteLine($"\nInforme o código referente ao seu cargo: ");
            Console.WriteLine("\n1 - Gerente");
            Console.WriteLine("2 - Vendedor");
            Console.WriteLine("3 - Supervisor");
            Console.WriteLine("4 - Motorista");
            Console.WriteLine("5 - Estoquista");
            Console.WriteLine("6 - Técnico de TI");
            Console.WriteLine("-----------------------------");
            cargo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            Console.WriteLine("Digite qual é o seu salário: ");
            Console.WriteLine("-----------------------------");
            salario = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("-----------------------------");

            switch (cargo)
            {
                case 1:
                    reajuste = salario + (salario * 10) / 100;
                    cargoX = "Gerente";
                    break;
                case 2:
                    reajuste = salario + (salario * 7) / 100;
                    cargoX = "Vendedor";
                    break;
                case 3:
                    reajuste = salario + (salario * 9) / 100;
                    cargoX = "Supervisor";
                    break;
                case 4:
                    reajuste = salario + (salario * 6) / 100;
                    cargoX = "Motorista";
                    break;
                case 5:
                    reajuste = salario + (salario * 5) / 100;
                    cargoX = "Estoquista";
                    break;
                case 6:
                    reajuste = salario + (salario * 8) / 100;
                    cargoX = "Técnico de TI";
                    break;
                default:
                    Console.WriteLine("Cargo inválido!");
                    break;
            }
            Console.WriteLine($"\nColaborador: {nome} \nCargo: {cargoX}");
            Console.WriteLine($"Novo salário: {reajuste}");
        }

    }
}