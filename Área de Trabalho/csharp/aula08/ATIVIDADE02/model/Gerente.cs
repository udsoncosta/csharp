using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE02.model
{
    public class Gerente : Funcionario
    {
        string filial;
        string setor;

        public Gerente(string nome, int matricula, int idade, int admissao, string cargo, string filial, string setor) :
        base(nome, matricula, idade, admissao, cargo)
        {
            this.filial = filial;
            this.setor = setor;
        }

        public string GetFilial()
        {
            return this.filial;
        }
        public void SetFilial(string filial)
        {
            this.filial = filial;
        }
        public string GetSetor()
        {
            return this.setor;
        }
        public void SetSetor(string setor)
        {
            this.setor = setor;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Filial: {this.filial}");
            Console.WriteLine($"Setor: {this.setor}");
        }
    }
}
