using PCDevLocadora.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace APCDevLocadora.Models
{
    public class Item
    {
        public int Id { get; set; }
        public int Quantidade { get; set; }
        public int Valor { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public int Duracao { get; set; }
        public int QuantidadeDeOscars { get; set; }
        public string Nome { get; set; }
        public string Genero { get; set; }


        public Item()
        {
            List<Item> Itens = Armazenamento.Biblioteca;
            int quantidadeDeItens = Itens.Count;
            Id = quantidadeDeItens++;
        }
       
    }
}
