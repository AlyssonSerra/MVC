
using System.Data.Entity.ModelConfiguration;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class ProdutoConfiguration : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfiguration()
        {
            HasKey(p => p.COD_PRODUTO);

            //Property(p => p.COD_PRODUTO)
            //.HasMaxLength(4);

            Property(p => p.DES_PRODUTO)
                .HasMaxLength(30);

            Property(p => p.STA_STATUS)
                .HasMaxLength(1);

        }
    }
}

