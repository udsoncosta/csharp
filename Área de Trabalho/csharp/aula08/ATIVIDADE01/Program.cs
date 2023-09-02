using ATIVIDADE01.model;

public class Program
{
    static void Main(string[] args)
    {
        Cliente c1 = new Cliente("Danilo", 2003, "Rua 123", 123456789);
        c1.Visualizar();

        Cliente c2 = new Cliente("Roberto", 1980, "Avenida Bandeirantes", 121212121);
        c2.Visualizar();

        PessoaFisica pf = new PessoaFisica("Danilo", 2003, "Rua 123", 123456789, "Estudante", "Conta Corrente");
        pf.Visualizar();

        PessoaJuridica pj = new PessoaJuridica("BrasilCar", 1950, "Avenida Paulista", 232425272 ,"Automobilística") ;
        pj.Visualizar();

    }


}