using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasDados.EntidadesConfig
{
    public class SubGrupoProdutoConfig : EntityTypeConfiguration<SubGrupoProduto>
    {
        public SubGrupoProdutoConfig()
        {
            // Tabela
            ToTable("SubGrupoProduto");

            // Chave primária
            HasKey(t => t.Codigo);

            // Propriedades
            Property(t => t.Codigo)
                .IsRequired()
                .HasColumnOrder(0)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.CodigoExterno)
                .IsOptional()
                .HasColumnOrder(1);

            Property(t => t.GrupoCodigoExterno)
                .IsOptional()
                .HasColumnOrder(2);

            Property(t => t.Nome)
                .IsOptional()
                .HasColumnOrder(3);

            Property(t => t.DataExclusao)
                .IsOptional()
                .HasColumnOrder(4);

            Property(t => t.GrupoCodigo)
                .HasColumnOrder(5);

            Property(t => t.DataCriacaoRegistro);

            Property(t => t.DataAtualizacaoRegistro);

            //Relacionamentos
            HasRequired(t => t.Grupo)
                .WithMany(t => t.SubGrupoProduto)
                .HasForeignKey(d => d.GrupoCodigo);
        }
    }
}
