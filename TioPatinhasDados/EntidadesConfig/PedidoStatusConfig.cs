using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasDados.EntidadesConfig
{
    public class PedidoStatusConfig : EntityTypeConfiguration<PedidoStatus>
    {
        public PedidoStatusConfig()
        {
            // Tabela
            ToTable("PedidoStatus");

            // Chave primária
            HasKey(t =>  t.Codigo);

            // Propriedades
            Property(t => t.Codigo)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.Descricao)
                .IsRequired();

            Property(t => t.DataCriacaoRegistro);

            Property(t => t.DataAtualizacaoRegistro);

        }
    }
}
