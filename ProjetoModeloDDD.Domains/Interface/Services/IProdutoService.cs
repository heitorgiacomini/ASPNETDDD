using ProjetoModeloDDD.Domains.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domains.Interface.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        IEnumerable<Produto> BurcarPorNome(string nome);


    }
}
