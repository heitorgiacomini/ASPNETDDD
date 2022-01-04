using ProjetoModeloDDD.Application.Interface;
using ProjetoModeloDDD.Domains.Entities;
using ProjetoModeloDDD.Domains.Interface.Services;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoModeloDDD.Application
{
    public class ClienteAppService : AppServiceBase<Cliente>, IClienteAppService
    {
        private readonly IClienteService _clienteService;

        public ClienteAppService(IClienteService clienteService)
            : base(clienteService)
        {
            _clienteService = clienteService;
        }

        public IEnumerable<Cliente> ObterClienteEspecial()
        {
            return _clienteService.ObterClienteEspecial(_clienteService.GetAll());
        }
    }
}
