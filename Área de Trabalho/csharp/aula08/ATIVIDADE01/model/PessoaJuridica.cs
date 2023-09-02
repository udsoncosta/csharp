using ATIVIDADE01.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE01.model
{
    public class PessoaJuridica : Cliente
    {
        private string ramo;

        public PessoaJuridica(string nome, int idade, string endereco, int documentoRG, string ramo)
            : base (nome, idade, endereco, documentoRG)

        {
            this.ramo = ramo;
        }
        public string GetRamo()
        {
            return this.ramo;
        }
        public void SetRamo(string ramo)
        {
            this.ramo = ramo;
        }
        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Ramo: {this.ramo}");
        }
    }
}
