

using System.Data.Entity.ModelConfiguration;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ProdutoCosifConfiguration : EntityTypeConfiguration<ProdutoCosif>
    {
        public ProdutoCosifConfiguration()
        {
            HasKey(c => c.COD_COSIF);

            Property(c => c.COD_COSIF)
            .HasMaxLength(11);

            Property(c => c.COD_CLASSIFICACAO)
                .HasMaxLength(6);

            Property(c => c.STA_STATUS)
                .HasMaxLength(1);

            HasRequired(p => p.Produto)
                  .WithMany()
                  .HasForeignKey(p => p.COD_PRODUTO);

            //Property(p => p.COD_PRODUTO)
            //.HasMaxLength(4);


        }
    }
}


