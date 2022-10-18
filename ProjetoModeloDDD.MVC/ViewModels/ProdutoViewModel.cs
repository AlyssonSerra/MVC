using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.MVC.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public int COD_PRODUTO { get; set; }

        [Required(ErrorMessage = "Preencha o campo Nome")]
        public string DES_PRODUTO { get; set; }

        public string STA_STATUS { get; set; }

        public IEnumerable<MovimentoManualViewModel> MovimentosManual { get; set; }


    }
}