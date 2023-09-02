using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE01.model
{
    public class Cliente
    {
        private string nome = string.Empty;
        private int idade;
        private string endereco;
        private int documentoRG;

        public Cliente(string nome, int idade, string endereco, int documentoRG)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
            this.documentoRG = documentoRG;
        }

        /*Métodos Get e Set*/
        public string GetNome()

        {
            return nome;
        }

        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public int GetIdade()
        {
            return idade;
        }

        public void SetIdade(int idade)
        {
            this.idade = idade;
        }

        public string GetEndereco()
        {
            return endereco;
        }

        public void SetEndereco(string endereco)
        {
            this.endereco = endereco;
        }

        public int GetDocumentoRG()
        {
            return documentoRG;
        }

        public void SetDocumenoRG(int documentoRG)
        {
            this.documentoRG = documentoRG;
        }

        public virtual void Visualizar()
        {

            Console.WriteLine("**********************************************");
            Console.WriteLine("Dados da conta");
            Console.WriteLine("**********************************************");
            Console.WriteLine($"Nome do cliente: {this.nome}");
            Console.WriteLine($"Ano de nascimento: {this.idade} anos");
            Console.WriteLine($"Endereço: {this.endereco}");
            Console.WriteLine($"Documento (CPF/CNPJ: {this.documentoRG}");
        }
    }

}



