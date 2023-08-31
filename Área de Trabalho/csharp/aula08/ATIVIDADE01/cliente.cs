﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ATIVIDADE01.Cliente
{
    public class Cliente
    {
        private string nome = string.Empty;
        private int idade;
        private string endereco;
        private int documentoRG;
        private string estadoCivil = string.Empty;

        public Cliente(string nome, int idade, string endereco, int documentoRG, string estadoCivil)
        {
            this.nome = nome;
            this.idade = idade;
            this.endereco = endereco;
            this.documentoRG = documentoRG;
            this.estadoCivil = estadoCivil;
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

        public string GetEstadoCivil()
        {
            return estadoCivil;
        }

        public void SetEstadoCivil(string estadoCivil)
        {
            this.estadoCivil = estadoCivil;
        }
        public void Visualizar()
        {

            Console.WriteLine("**********************************************");
            Console.WriteLine("Dados da conta");
            Console.WriteLine("**********************************************");
            Console.WriteLine($"Nome do cliente: {this.nome}");
            Console.WriteLine($"Idade do cliente: {this.idade} anos");
            Console.WriteLine($"Endereço: {this.endereco}");
            Console.WriteLine($"Documento de identidade: {this.documentoRG}");
            Console.WriteLine($"Estado civil: {this.estadoCivil}");
        }
        }

    }



