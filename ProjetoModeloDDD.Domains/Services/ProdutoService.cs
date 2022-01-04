using ProjetoModeloDDD.Domains.Entities;
using ProjetoModeloDDD.Domains.Interface.Repositories;
using ProjetoModeloDDD.Domains.Interface.Services;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Domains.Services
{
    public class ClienteService : ServiceBase<Cliente>, IClienteService
    {
        private readonly IClienteRepository _clienteRepository;

         
        public ClienteService(IClienteRepository clienteRepository)
            : base(clienteRepository)
        {
            _clienteRepository = clienteRepository;
        }

        public IEnumerable<Cliente> ObterClienteEspecial(IEnumerable<Cliente> cliente)
        {
            return cliente.Where(c => c.ClienteEspecial(c));
        }
    }
}
