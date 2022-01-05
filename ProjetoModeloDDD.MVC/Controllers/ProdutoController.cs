using AutoMapper;
using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domains.Entities;
using ProjetoModeloDDD.MVC.ViewModels;
using System.Collections.Generic;
using System.Web.Mvc;


namespace ProjetoModeloDDD.MVC.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly IClienteAppService _clienteApp;
        private readonly IProdutoAppService _produtoApp;
        public ProdutoController(IProdutoAppService produtoApp, IClienteAppService clienteApp)
        {
            _clienteApp = clienteApp;
            _produtoApp = produtoApp;
        }


        // GET: Produto
        public ActionResult Index()
        {
            var produtoViewModel = Mapper.Map<IEnumerable<Produto>, IEnumerable<ProdutoViewModel>>(_produtoApp.GetAll());
            return View(produtoViewModel);
        } 

        // GET: Produto/Details/5
        public ActionResult Details(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);
            return View(produtoViewModel);
        }

        // GET: Produto/Create
        public ActionResult Create()
        {
            ViewBag.Cliente_Id = new SelectList(_clienteApp.GetAll(), "Cliente_Id", "Cliente_Nome");
            return View();
        }

        // POST: Produto/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoApp.Add(produtoDomain);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Cliente_Id = new SelectList(_clienteApp.GetAll(), "Cliente_Id", "Cliente_Nome", produto.Cliente_Id);
                return View(produto);
            }
        }

        // GET: Produto/Edit/5
        public ActionResult Edit(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);
            ViewBag.Cliente_Id = new SelectList(_clienteApp.GetAll(), "Cliente_Id", "Cliente_Nome", produtoViewModel.Cliente_Id);
            return View(produtoViewModel);
        }

        // POST: Produto/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ProdutoViewModel produto)
        {
            if (ModelState.IsValid)
            {
                var produtoDomain = Mapper.Map<ProdutoViewModel, Produto>(produto);
                _produtoApp.Update(produtoDomain);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Cliente_Id = new SelectList(_clienteApp.GetAll(), "Cliente_Id", "Cliente_Nome", produto.Cliente_Id);
                return View(produto);
            }
        }


        // GET: Produto/Delete/5
        public ActionResult Delete(int id)
        {
            var produto = _produtoApp.GetById(id);
            var produtoViewModel = Mapper.Map<Produto, ProdutoViewModel>(produto);
            return View(produtoViewModel);

        }

        // POST: Produto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var produto = _produtoApp.GetById(id);
            _produtoApp.Remove(produto);

            return RedirectToAction("Index");
        }
    }
}