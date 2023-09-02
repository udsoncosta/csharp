using ATIVIDADE01.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE01.model
{
    public class PessoaFisica : Cliente
    {
             private string ocupacao ;
             private string tipoConta;

        public PessoaFisica(string nome, int idade, string endereco, int documentoRG, string ocupacao, string tipoConta)
            : base(nome, idade, endereco, documentoRG)
        {
            this.ocupacao = ocupacao;
            this.tipoConta = tipoConta;

        }
        public string GetOcupacao()
        {
            return this.ocupacao;
        }
        public void SetOcupacao(string ocupacao)
        {
            this.ocupacao = ocupacao;
        }

        public string GetTipoConta()
        {
            return this.tipoConta;
        }
        public void SetTipoConta(string tipoConta)
        {
            this.tipoConta = tipoConta;
        }

        public override void Visualizar()
        {
            base.Visualizar();
            Console.WriteLine($"Ocupação: {this.ocupacao}");
            Console.WriteLine($"Tipo de conta do cliente: {this.tipoConta}");
        }
    }
}
