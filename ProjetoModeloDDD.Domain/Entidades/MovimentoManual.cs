using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class MovimentoManual
    {
        public int NUM_LANCAMENTO { get; set; }

       // public Guid NUM_LANCAMENTO { get; set; }

        public int DAT_MES { get; set; }
        public int DAT_ANO { get; set; }
                        
        public ProdutoCosif ProdutoCosif { get; set; }
        public string COD_COSIF { get; set; }

        public string DES_DESCRICAO { get; set; }

        public DateTime DAT_MOVIMENTO { get; set; }

        public string COD_USUARIO { get; set; }

        public decimal VAL_VALOR { get; set; }

        public int COD_PRODUTO { get; set; }
        public Produto Produto { get; set; }

    }
}




