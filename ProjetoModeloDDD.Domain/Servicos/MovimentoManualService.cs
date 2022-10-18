using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Domain.Services
{
    public class MovimentoManualService : ServiceBase<MovimentoManual>, IMovimentoManualService
    {

        private readonly IMovimentoManualRepository _movimentoManualRepository;

        public MovimentoManualService(IMovimentoManualRepository movimentoManualRepository)
            : base(movimentoManualRepository)
        {
            _movimentoManualRepository = movimentoManualRepository;
        }

    }
}


