using System.Security.Cryptography;

namespace ATIVIDADE02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            funcionario c1= new funcionario("Lucas", 100025, 28, 2023, "Professor");

            c1.Visualizar();


            funcionario c2 = new funcionario("Marcela", 100012, 36, 2021, "Diretora");

            c2.Visualizar();
        }
    }
}