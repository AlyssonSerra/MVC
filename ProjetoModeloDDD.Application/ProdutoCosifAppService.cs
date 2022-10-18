

using System.Collections.Generic;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Application
{
    public class ProdutoCosifAppService : AppServiceBase<ProdutoCosif>, IProdutoCosifAppService
    {
        private readonly IProdutoCosifService _produtoCosifService;

        public ProdutoCosifAppService(IProdutoCosifService produtoCosifService)
            : base(produtoCosifService)
        {
            _produtoCosifService = produtoCosifService;
        }
    }
}
