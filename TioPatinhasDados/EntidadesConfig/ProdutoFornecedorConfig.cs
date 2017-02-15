using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasDados.EntidadesConfig
{
    public class ProdutoFornecedorConfig : EntityTypeConfiguration<ProdutoFornecedor>
    {
        public ProdutoFornecedorConfig()
        {
            // Tabela
            ToTable("PrecoProduto");

            // Chave primária
            HasKey(t => new { t.ProdutoCodigo, t.FornecedorCodigo });

            // Propriedades
            Property(t => t.ProdutoCodigo)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.FornecedorCodigo)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.CodigoProdutoFornecedor)
                .IsRequired();

            Property(t => t.QuantidadeDiasGarantia)
                .IsRequired();

            Property(t => t.PrecoTabela)
                .IsRequired();

            Property(t => t.PrecoPromocional)
                .IsRequired();

            Property(t => t.DataCriacaoRegistro);

            Property(t => t.DataAtualizacaoRegistro);


            //Relacionamentos
            HasRequired(t => t.Produto)
                .WithMany(t => t.ProdutoFornecedor)
                .HasForeignKey(d => d.ProdutoCodigo);

            HasRequired(t => t.Fornecedor)
                .WithMany(t => t.ProdutoFornecedor)
                .HasForeignKey(d => d.FornecedorCodigo);
        }
    }
}
