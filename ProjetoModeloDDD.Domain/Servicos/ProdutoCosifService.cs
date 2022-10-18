

using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Domain.Services
{
    public class ProdutoCosifService : ServiceBase<ProdutoCosif>, IProdutoCosifService
    {
        private readonly IProdutoCosifRepository _produtoCosifRepository;

        public ProdutoCosifService(IProdutoCosifRepository produtoCosifRepository)
            : base(produtoCosifRepository)
        {
            _produtoCosifRepository = produtoCosifRepository;
        }
    }
}
