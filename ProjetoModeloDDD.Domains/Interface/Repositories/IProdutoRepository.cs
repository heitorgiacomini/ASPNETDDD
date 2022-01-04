using ProjetoModeloDDD.Domains.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domains.Interface.Repositories
{
    public interface IProdutoRepository : IRepositoryBase<Produto>
    {
        IEnumerable<Produto> BurcarPorNome(string nome);


    }
}
