using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domains.Entities;
using ProjetoModeloDDD.Domains.Interface.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Application
{
    public class ProdutoAppService : AppServiceBase<Produto>, IProdutoAppService
    {
        private readonly IProdutoService _produtoService;

        public ProdutoAppService(IProdutoService produtoService)
            : base(produtoService)
        {
            _produtoService = produtoService;
        }

        public IEnumerable<Produto> BurcarPorNome(string nome)
        {
            return _produtoService.BurcarPorNome(nome);
        }
    }
}
