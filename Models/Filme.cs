using APCDevLocadora.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCDevLocadora.Models
{
    public class Filme : Item
    {
        public Filme(string nome, string genero, int codigo)
        {
            Nome = nome;
            Genero = genero;
            Codigo = codigo;
        }

        
       
        
    }
}
