using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasDados.EntidadesConfig
{
    public class ProdutoConfig : EntityTypeConfiguration<Produto>
    {
        public ProdutoConfig()
        {
            // Tabela
            ToTable("Produto");

            // Chave primária
            HasKey(t => t.Codigo);

            // Propriedades
            Property(t => t.Codigo)
                .IsRequired()
                .HasColumnOrder(0)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.CodigoExterno)
                .IsRequired()
                .HasMaxLength(50)
                .HasColumnOrder(1);

            Property(t => t.CodigoPai)
                .IsRequired()
                .HasColumnOrder(2);

            Property(t => t.Nome)
                .IsRequired()
                .HasMaxLength(100)
                .HasColumnOrder(3);

            Property(t => t.CodigoBarras)
                .IsOptional()
                .HasMaxLength(50)
                .HasColumnOrder(7);

            Property(t => t.Altura)
                .IsOptional();

            Property(t => t.Largura)
                .IsOptional();

            Property(t => t.Comprimento)
                .IsOptional();

            Property(t => t.Peso)
                .IsOptional();

            Property(t => t.Kit)
                .IsRequired();
            
            Property(t => t.DataAlteracao)
                .IsOptional();

            Property(t => t.DataDesativado)
               .IsOptional();

            Property(t => t.DataCriacaoRegistro);

            Property(t => t.DataAtualizacaoRegistro);

            //Relacionamentos
            HasRequired(t => t.Classe)
                .WithMany(t => t.Produto)
                .HasForeignKey(d => d.ClasseCodigo);

            HasRequired(t => t.Familia)
                .WithMany(t => t.Produto)
                .HasForeignKey(d => d.FamiliaCodigo);

            HasRequired(t => t.Marca)
                .WithMany(t => t.Produto)
                .HasForeignKey(d => d.MarcaCodigo);

            HasRequired(t => t.SubGrupoProduto)
                .WithMany(t => t.Produto)
                .HasForeignKey(d => d.SubGrupoProdutoCodigo);
        }
    }
}
