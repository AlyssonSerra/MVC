
using System.Collections.Generic;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Services;

namespace ProjetoModeloDDD.Application
{
    public class MovimentoManualAppService : AppServiceBase<MovimentoManual>, IMovimentoManualAppService
    {
        private readonly IMovimentoManualService _movimentoManualService;

        public MovimentoManualAppService(IMovimentoManualService movimentoManualService)
            : base(movimentoManualService)
        {
            _movimentoManualService = movimentoManualService;
        }
    }
}
