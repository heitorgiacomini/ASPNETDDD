using System.ComponentModel.DataAnnotations;

namespace ProjetoModeloDDD.Domain.Entities
{
    public class Cliente
    {
        [Key]
        public long Cliente_Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Email { get; set; }
        public DateTime DataCadastro { get; set; }
        public bool Ativo { get; set; }

        public bool ClienteEspecial(Cliente cliente)
        {
            return cliente.Ativo && DateTime.Now.Year - cliente.DataCadastro.Year >= 5;

        }
    }
}
