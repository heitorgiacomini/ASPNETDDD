using System;
using System.Collections.Generic;

namespace ProjetoModeloDDD.Domains.Entities
{
    public class Cliente
    {
        public int Cliente_Id { get; set; }
        public string Cliente_Nome { get; set; }
        public string Cliente_Sobrenome { get; set; }
        public string Cliente_Email { get; set; }
        
        public DateTime Cliente_DataCadastro { get; set; }
        public bool Cliente_Ativo { get; set; }
        public IEnumerable<Produto> Produtos{ get; set; }
        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Cliente_Ativo && DateTime.Now.Year - cliente.Cliente_DataCadastro.Year >= 5;
        }
    }
}
