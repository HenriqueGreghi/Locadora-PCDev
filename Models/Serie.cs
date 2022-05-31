using APCDevLocadora.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCDevLocadora.Models
{
    public class Serie : Item
    {
        public int Temporadas { get; set; }
        public int Emmies { get; set; }
        public string Nome { get; internal set; }
        public string Genero { get; internal set; }
    }
}
