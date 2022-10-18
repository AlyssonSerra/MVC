
using System.Data.Entity.ModelConfiguration;
using ProjetoModeloDDD.Domain.Entities;

namespace ProjetoModeloDDD.Infra.Data.EntityConfig
{
    public class MovimentoManualConfiguration : EntityTypeConfiguration<MovimentoManual>
    {
        public MovimentoManualConfiguration()
        {

            //HasKey(p => new { p.NUM_LANCAMENTO, p.DAT_MES, p.DAT_ANO });
            HasKey(p => p.NUM_LANCAMENTO);
            Property(p => p.NUM_LANCAMENTO);

            Property(p => p.DAT_MES);
            Property(p => p.DAT_ANO);

            Property(p => p.DES_DESCRICAO)
                .IsRequired()
                    .HasMaxLength(50);

            Property(p => p.DAT_MOVIMENTO);

            Property(p => p.COD_USUARIO)
                .IsRequired()
                    .HasMaxLength(15);

            Property(p => p.VAL_VALOR);

            HasRequired(p => p.Produto)
                .WithMany()
                .HasForeignKey(p => p.COD_PRODUTO);
         

            //HasRequired(p => p.ProdutoCosif)
            //      .WithMany()
            //      .HasForeignKey(p => p.COD_COSIF);
            //Property(p => p.COD_COSIF)
            //.HasMaxLength(11);

        }
    }
}
