﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cantinaa
{
    internal class Usuario
    {
        public string Nome { get; set; }

        public string Senha { get; set; }

        public string Tipo { get; set; } 

        public static bool Adm {  get; set; }

        public Usuario(string nome, string senha, string tipo)
        {
            Nome = nome;
            Senha = senha;
            Tipo = tipo;
        }
    }
}
