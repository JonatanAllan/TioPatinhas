using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasDados.EntidadesConfig
{
    public class PedidoConfig : EntityTypeConfiguration<Pedido>
    {
        public PedidoConfig()
        {
            // Tabela
            ToTable("Pedido");

            // Chave primária
            HasKey(t => t.Codigo);

            // Propriedades
            Property(t => t.Codigo)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.CodigoExterno)
                .IsRequired();

            Property(t => t.CodigoExterno)
                .IsRequired();

            Property(t => t.FornecedorCodigo)
                .IsRequired();

            Property(t => t.StatusCodigo)
                .IsRequired();

            Property(t => t.PedidoOrigem)
               .IsRequired();

            Property(t => t.ValorPedido)
               .IsRequired();

            Property(t => t.ValorFrete)
               .IsRequired();

            Property(t => t.ValorEncargos)
               .IsRequired();

            Property(t => t.ValorDesconto)
              .IsRequired();

            Property(t => t.DataCompra)
             .IsRequired();

            Property(t => t.DataPrazoEntrega)
            .IsRequired();

            Property(t => t.DataCriacaoRegistro);

            Property(t => t.DataAtualizacaoRegistro);

            //Relacionamentos
            HasRequired(t => t.Status)
                .WithMany(t => t.Pedido)
                .HasForeignKey(t => t.StatusCodigo);

            HasRequired(t => t.Fornecedor)
                .WithMany(t => t.Pedido)
                .HasForeignKey(t => t.FornecedorCodigo);
        }
    }
}
