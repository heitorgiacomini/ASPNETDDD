using ProjetoModeloDDD.Infra.Data.EntityConfig;
using ProjetoModeloDDD.Domains.Entities;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using SqlProviderServices = System.Data.Entity.SqlServer.SqlProviderServices;

namespace ProjetoModeloDDD.Infra.Data.Context
{
    public class ProjetoModeloDDDContext : DbContext
    {
        public ProjetoModeloDDDContext()
            : base("ProjetoModeloDDD")
        {
        }

        public DbSet<Cliente> Cliente { get; set; }
        public DbSet<Produto> Produto { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();

            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType.Name + "_Id")
                .Configure(p => p.IsKey());

            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(250));

            modelBuilder.Configurations.Add(new ClienteConfiguration());
            modelBuilder.Configurations.Add(new ProdutoConfiguration());            
        }




    }
}

