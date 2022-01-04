using ProjetoModeloDDD.Domains.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.Produto_Id);

            Property(p => p.Produto_Nome)
                .IsRequired()
                .HasMaxLength(250);

            Property(p => p.ProdutoValor)
                .IsRequired();

            HasRequired(p => p.Cliente)
                .WithMany()
                .HasForeignKey(p => p.Cliente_id);   








        }
    }
}
