﻿namespace RH
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? nome;
            int cargo;
            float salario, reajuste;

            Console.WriteLine("Qual seu nome? ");
            nome = Console.ReadLine();

            Console.WriteLine("1 - Supervisor");
            Console.WriteLine("2 - Diretor");
            Console.WriteLine("3 - Gerente");
            Console.WriteLine("4 - Outros");

            Console.WriteLine("\nDigite o seu cargo: ");
            cargo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o seu salário: ");
            salario = Convert.ToSingle(Console.ReadLine());

            switch (cargo)
            {
                case 1:
                    reajuste = (salario * 0.07F);
                    break;
                case 2:
                    reajuste = (salario * 0.09F);
                    break;
                case 3:
                    reajuste = (salario * 0.05F);
                    break;
                default:
                    reajuste = (salario * 0.12F);
                    break;
            }

            Console.WriteLine($"O reajuste do salário do(a) {nome} é de {reajuste}");
            Console.WriteLine($"O reajuste do salário do(a) {nome} é de {reajuste}");

        }
    }
}