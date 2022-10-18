
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class MovimentoManualViewModel
    {

        public MovimentoManualViewModel()
        {
           
            COD_USUARIO = "TESTE";
        }

        public int NUM_LANCAMENTO { get; set; }
        public int DAT_MES { get; set; }
        public int DAT_ANO { get; set; }

        public string DES_DESCRICAO { get; set; }

        public DateTime DAT_MOVIMENTO { get; set; }

        public string COD_USUARIO { get; set; }

        public string COD_PRODUTO { get; set; }
        public string COD_COSIF { get; set; }

        public int VAL_VALOR { get; set; }

        public  ProdutoViewModel Produto { get; set; }

        public ProdutoCosifViewModel ProdutoCosif { get; set; }


    }
}