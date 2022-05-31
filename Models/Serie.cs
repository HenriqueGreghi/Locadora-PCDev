using APCDevLocadora.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCDevLocadora.Models
{
    public class Serie : Item
    {
        public Serie(string nome, string genero)
        {
            Nome = nome;
            Genero = genero;
        }

        public int Temporadas { get; set; }
        public int Emmies { get; set; }
        public string Nome { get; internal set; }
        public string Genero { get; internal set; }
    }
}
