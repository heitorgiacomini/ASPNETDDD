using ProjetoModeloDDD.Domains.Entities;
using ProjetoModeloDDD.Domains.Interface;
using ProjetoModeloDDD.Domains.Interface.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Infra.Data.Repositories
{
    public class ProdutoRepository : RepositoryBase<Produto>, IProdutoRepository
    {
        public IEnumerable<Produto> BurcarPorNome(string nome)
        {
            return Db.Produto.Where(p => p.Produto_Nome == nome);
        }

    }
}
