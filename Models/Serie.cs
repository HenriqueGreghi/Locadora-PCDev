using APCDevLocadora.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCDevLocadora.Models
{
    public class Serie : Item
    {
        public Serie(string nome, string genero, int codigo)
        {
            Nome = nome;
            Genero = genero;
            Codigo = codigo;
        }
        

       
    }
}
