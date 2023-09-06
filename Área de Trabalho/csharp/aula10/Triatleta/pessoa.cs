﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Triatleta
{
        public abstract class Pessoa
        {
            private string nome;

            public Pessoa(string nome)
            {
                this.nome = nome;
            }

            public string GetNome()
            {
                return nome;
            }

            public void SetNome(string nome)
            {
                this.nome = nome;
            }

            public void Cansou()
            {
                Console.WriteLine("\nCansou...");
            }
        }
    }


