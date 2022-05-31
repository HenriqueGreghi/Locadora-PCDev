using PCDevLocadora.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PCDevLocadora.Services
{
    public class FilmeServices
    {
        public static List<Filme> _listaFilmes = new List<Filme>();

        public void ListarFilme()
        {
            Console.WriteLine("NOME     - Genero ");
            foreach (Filme filme in _listaFilmes)
            {
                Console.WriteLine(filme.Nome + " - " + filme.Genero);
            }
        }

        public void CadastrarFilme()
        {
            Console.WriteLine("Digite o nome do filme:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o nome do gênero do filme:");
            string genero = Console.ReadLine();

           
            Filme filme = new Filme(nome, genero);
            _listaFilmes.Add(filme);
        }
    }
}