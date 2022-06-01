using APCDevLocadora.Models;
using PCDevLocadora.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCDevLocadora.Repository
{
    public class Armazenamento
    {
         public static List<Usuario>Usuarios = new List<Usuario>();
         public static List<Filme> Filmes = new List<Filme>();

        public static List<Item> Biblioteca { get; internal set; }
    }
}
