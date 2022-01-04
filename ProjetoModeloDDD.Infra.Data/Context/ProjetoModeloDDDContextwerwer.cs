using ProjetoModeloDDD.Domain.Entities;
using System.Data.Entity;

namespace ProjetoModeloDDD.Infra.Data.Context
{
    public class ProjetoModeloDDDContext : DbContext
    {
        public ProjetoModeloDDDContext()
            : base("ProjetoModeloDDD")
        {
        }

        public DbSet<Cliente> Cliente { get; set; }

    }
}
