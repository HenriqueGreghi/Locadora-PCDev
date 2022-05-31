using System;
using System.Collections.Generic;
using System.Text;
using PCDevLocadora.Models;

namespace PCDevLocadora.Services
{
    public class ServicesItem
    {
        DateTime DataDaLocacao = DateTime.Now;

        DateTime Devolucao = DataDaLocacao.AddDays(3);


    }
}
