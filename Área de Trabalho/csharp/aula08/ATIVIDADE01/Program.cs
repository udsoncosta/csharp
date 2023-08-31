using ATIVIDADE01.Cliente;
namespace Atividade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cliente c1 = new Cliente("Danilo", 20, "Rua 123", 123456789, "Solteiro");
            c1.Visualizar();

            Cliente c2 = new Cliente("Roberto", 40, "Avenida Bandeirantes", 121212121, "Casado");
            c2.Visualizar();
        }


    }
}