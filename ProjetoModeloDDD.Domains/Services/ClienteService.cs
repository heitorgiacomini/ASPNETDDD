using ProjetoModeloDDD.Domains.Entities;
using ProjetoModeloDDD.Domains.Interface.Repositories;
using ProjetoModeloDDD.Domains.Interface.Services;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domains.Services
{
    public class ProdutoService : ServiceBase<Produto>, IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

         
        public ProdutoService(IProdutoRepository produtoRepository)
            : base(produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public IEnumerable<Produto> BurcarPorNome(string nome)
        {
            return _produtoRepository.BurcarPorNome(nome);
        }
    }
}
