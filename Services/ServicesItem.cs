using System;
using System.Collections.Generic;
using System.Text;
using PCDevLocadora.Models;

namespace PCDevLocadora.Services
{
    public class ServicesItem
    {
        public ServicesItem()
        {
            DataDaLocacao = DateTime.Now;
            Devolucao = DataDaLocacao.AddDays(3);

        }

        public DateTime DataDaLocacao { get; }
        public DateTime Devolucao { get; }
    }
}
