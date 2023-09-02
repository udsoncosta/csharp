using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE02.model;

public class Vendedor : Funcionario
{
    int salario;
    int metaMes;
    public Vendedor(string nome, int matricula, int idade, int admissao, string cargo, int salario, int metaMes)
        : base(nome, matricula, idade, admissao, cargo)
    {
        this.salario = salario;
        this.metaMes = metaMes;
    }

    public int GetSalario()
    {
        return this.salario;
    }
    public void SetSalario(int salario)
    {
        this.salario = salario;
    }

    public int GetMetaMes()
    {
        return this.metaMes;
    }
    public void SetMetaMes(int metaMes)
    {
        this.metaMes = metaMes;
    }
    public override void Visualizar()
    {
        base.Visualizar();
        Console.WriteLine($"Salário mensal: {this.salario}");
        Console.WriteLine($"Metas de vendas mensais: {this.metaMes}");
    }
}
