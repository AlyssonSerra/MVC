

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProdutoCosifViewModel
    {
        [Key]
        public int COD_COSIF { get; set; }

        public string COD_CLASSIFICACAO { get; set; }

        public string STA_STATUS { get; set; }

    }
}