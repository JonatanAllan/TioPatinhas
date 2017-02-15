using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasDados.EntidadesConfig
{
    public class FornecedorConfig : EntityTypeConfiguration<Fornecedor>
    {
        public FornecedorConfig()
        {
            // Tabela
            ToTable("Cliente");

            // Chave primária
            HasKey(t => t.Codigo);

            // Propriedades
            Property(t => t.Codigo)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.CodigoExterno)
                .IsRequired();

            Property(t => t.Email)
                .IsRequired()
                .HasMaxLength(100);

            Property(t => t.Cnpj)
                .IsRequired();

            Property(t => t.InscricaoEstadual)
              .IsOptional()
              .HasMaxLength(15);

            Property(t => t.InscricaoMunicipal)
              .IsOptional()
              .HasMaxLength(15);

            Property(t => t.RazaoSocial)
                .HasMaxLength(100)
                .IsRequired();

            Property(t => t.Telefone)
                .HasMaxLength(15)
                .IsRequired();

            Property(t => t.Celular)
                .HasMaxLength(15)
                .IsOptional();

            Property(t => t.DataAlteracao)
               .IsOptional();

            Property(t => t.DataDesativado)
               .IsOptional();

            Property(t => t.DataCriacaoRegistro);

            Property(t => t.DataAtualizacaoRegistro);
        }
    }
}
