﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATIVIDADE02
{
    public class funcionario
    {
        private string nome = string.Empty;
        private int matricula;
        private int idade;
        private int admissao;
        private string cargo = string.Empty;

        public funcionario(string nome, int matricula, int idade, int admissao, string cargo)
        {
            this.nome = nome;
            this.matricula = matricula;
            this.idade = idade;
            this.admissao = admissao;
            this.cargo = cargo;
        }
        public string GetNome()
        {
            return nome;
        }
        public void SetNome(string nome)
        {
            this.nome = nome;
        }

        public int GetMatricula()
        {
            return matricula;
        }
        public void SetMatricula(int matricula)
        {
            this.matricula = matricula;
        }
        public int GetIdade()
        {
            return idade;
        }
        public void SetIdade(int idade)
        {
            this.idade = idade;
        }
        public int GetAdmissa0()
        {
            return admissao;
        }
        public void SetAdmissao(int admissao)
        {
            this.admissao = admissao;
        }
        public string GetCargo()
        {
            return cargo;
        }
        public void SetProfissao(string cargo)
        {
            this.cargo = cargo;
        }
        public void Visualizar()
         
        {
            Console.WriteLine("**********************************************************");
            Console.WriteLine("                                                          ");
            Console.WriteLine($"Nome: {this.nome}");
            Console.WriteLine($"Número de matrícula: {this.matricula}");
            Console.WriteLine($"Idade: {this.idade} anos");
            Console.WriteLine($"Ano de admissão: {this.admissao}");
            Console.WriteLine($"Cargo: {this.cargo}");
            Console.WriteLine("                                                          ");
            Console.WriteLine("**********************************************************");


        }
    

    }
}
