using ProjetoModeloDDD.Domains.Entities;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domains.Interface.Services
{
    public interface IClienteService : IServiceBase<Cliente>
    {
        IEnumerable<Cliente> ObterClienteEspecial(IEnumerable<Cliente> cliente);
    }
}
