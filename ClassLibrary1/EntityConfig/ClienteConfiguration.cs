using ProjetoModeloDDD.Domains.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ClienteConfiguration : EntityTypeConfiguration<Cliente>
    {
        public ClienteConfiguration()
        {
            HasKey(c => c.Cliente_Id);

            Property(c => c.Cliente_Nome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Cliente_Sobrenome)
                .IsRequired()
                .HasMaxLength(150);

            Property(c => c.Cliente_Email)
                .IsRequired()
                .HasMaxLength(150);








        }







    }
}