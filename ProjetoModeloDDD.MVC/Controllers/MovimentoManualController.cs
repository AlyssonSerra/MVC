using System.Collections.Generic;
using System.Web.Mvc;
using AutoMapper;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domain.Entities;
using ProjetoModeloDDD.MVC.ViewModels;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class MovimentoManualController : Controller
    {
        // GET: Produtos
        private readonly IProdutoAppService _produtoApp;
        private readonly IProdutoCosifAppService _produtoCosifApp;
        private readonly IMovimentoManualAppService _movimentoManualApp;

        public MovimentoManualController(IProdutoAppService produtoApp, IProdutoCosifAppService produtoCosifApp,
            IMovimentoManualAppService movimentoManualApp)
        {
            _produtoApp = produtoApp;
            _produtoCosifApp = produtoCosifApp;
            _movimentoManualApp = movimentoManualApp;
        }
        public ActionResult Index()
        {
            var movimentoManualViewModel = Mapper.Map<IEnumerable<MovimentoManual>, IEnumerable<MovimentoManualViewModel>>
                (_movimentoManualApp.GetAll());

            return View(movimentoManualViewModel);
        }

        public ActionResult Create()
        {
            ViewBag.COD_PRODUTO = new SelectList(_produtoApp.GetAll(), "COD_PRODUTO", "COD_PRODUTO");
            ViewBag.COD_COSIF = new SelectList(_produtoCosifApp.GetAll(), "COD_COSIF", "COD_COSIF");

            return View();

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(MovimentoManualViewModel movimentoManual)
        {
            if (ModelState.IsValid)
            {

                //ViewBag.DES_PRODUTO = new Select(_produtoApp.BuscarPorCogigo((movimentoManual.COD_PRODUTO)));

                var movimentoManualDomain = Mapper.Map<MovimentoManualViewModel, MovimentoManual>(movimentoManual);
                _movimentoManualApp.Add(movimentoManualDomain);

                return RedirectToAction("Index");
            }

            ViewBag.COD_PRODUTO = new SelectList(_produtoApp.GetAll(), "COD_PRODUTO", "COD_PRODUTO", movimentoManual.COD_PRODUTO);
            ViewBag.COD_COSIF = new SelectList(_produtoCosifApp.GetAll(), "COD_COSIF", "COD_COSIF", movimentoManual.COD_COSIF);
            return View(movimentoManual);
        }
    }
}