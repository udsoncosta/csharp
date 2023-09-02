using ATIVIDADE02.model;
using System.Security.Cryptography;

namespace ATIVIDADE02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Funcionario c1= new Funcionario("Lucas", 100025, 28, 2023, "Estoquista");

            c1.Visualizar();


            Funcionario c2 = new Funcionario("Marcela", 100012, 36, 2021, "Caixa");

            c2.Visualizar();

            Vendedor c3= new Vendedor("Lucas", 10001, 33, 2020, "Vendedor(a)", 2500, 25000);

            c3.Visualizar();

            Gerente c4 =new Gerente("Gabriela", 10009, 22, 2021, "Gerente", "São Paulo", "Vendas e Marketing");

            c4.Visualizar();
        }
    }
}