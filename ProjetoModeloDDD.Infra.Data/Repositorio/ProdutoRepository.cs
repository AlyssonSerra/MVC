﻿
using System.Collections.Generic;
using System.Linq;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.Domain.Interfaces.Repositories;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        //public Produto BuscarPorCodigo(string codigo)
        //{
        //    return Db.Produtos.Where(p => p.COD_PRODUTO == codigo).FirstOrDefault();
        //}
    }
}
