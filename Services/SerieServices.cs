using System;
using System.Collections.Generic;
using System.Text;
using PCDevLocadora.Models;

namespace PCDevLocadora.Services
{
    internal class SerieServices
    {
        private static List<Serie> _listaSeries = new List<Serie>();

        public void ListarSeries()
        {
            Console.WriteLine("NOME     - Genero ");
            foreach (Serie serie in _listaSeries)
            {
                Console.WriteLine(serie.Nome + " - " + serie.Genero);
            }
        }

        public void CadastrarSerie()
        {
            Console.WriteLine("Digite o nome da série:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite o nome do gênero da série:");
            string genero = Console.ReadLine();

            Serie serie = new Serie(nome, genero);
            _listaSeries.Add(serie);

        }


    }
}