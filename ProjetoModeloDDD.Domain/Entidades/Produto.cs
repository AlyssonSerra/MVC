using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Produto
    {
        public int COD_PRODUTO { get; set; }
        public string DES_PRODUTO { get; set; }
        public string STA_STATUS { get; set; }

        public IEnumerable<MovimentoManual> MovimentosManual { get; set; }

    }
}

