using APCDevLocadora.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCDevLocadora.Models
{
    public class Filme : Item
    {
        public Filme(string nome, string genero, string diretor)
        {
            Nome = nome;
            Genero = genero;
            Diretor = diretor;
        }

        public int Duracao { get; set; }
        public int QuantidadeDeOscars { get; set; }
        public string Nome { get; }
        public string Genero { get; }
        public string Diretor { get; }
    }
}
