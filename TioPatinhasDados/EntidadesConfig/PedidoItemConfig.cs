using System.Data.Entity.ModelConfiguration;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasDados.EntidadesConfig
{
    public class PedidoItemConfig : EntityTypeConfiguration<PedidoItem>
    {
        public PedidoItemConfig()
        {
            // Tabela
            ToTable("PedidoItem");

            // Chave primária
            HasKey(t => new { t.PedidoCodigo, t.ProdutoCodigo });

            Property(t => t.Quantidade)
                .IsRequired();

            Property(t => t.PrecoUnitario)
                .IsRequired();

            Property(t => t.DataCriacaoRegistro);

            Property(t => t.DataAtualizacaoRegistro);

            //Relacionamentos
            HasRequired(t => t.Pedido)
                .WithMany(t => t.PedidoItem)
                .HasForeignKey(t => t.PedidoCodigo);

            HasRequired(t => t.Produto)
                .WithMany(t => t.PedidoItem)
                .HasForeignKey(t => t.ProdutoCodigo);
        }
    }
}
