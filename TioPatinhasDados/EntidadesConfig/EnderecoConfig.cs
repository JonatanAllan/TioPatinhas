using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasDados.EntidadesConfig
{
    public class EnderecoConfig : EntityTypeConfiguration<Endereco>
    {
        public EnderecoConfig()
        {
            // Tabela
            ToTable("Endereco");

            // Chave primária
            HasKey(t => new { t.Codigo, t.FornecedorCodigo});

            // Propriedades
            Property(t => t.Codigo)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(t => t.Rua)
                .IsRequired();

            Property(t => t.Numero)
                .IsRequired();

            Property(t => t.Complemento)
                .IsOptional();

            Property(t => t.Referencia)
                .IsOptional();

            Property(t => t.Bairro)
                .IsRequired();

            Property(t => t.Municipio)
                .IsRequired();

            Property(t => t.Estado)
                .IsRequired();

            Property(t => t.Cep)
                .IsRequired();

            Property(t => t.CodigoIbge)
                .IsRequired();

            Property(t => t.DataCriacaoRegistro);

            Property(t => t.DataAtualizacaoRegistro);

            //Relacionamentos
            HasRequired(t => t.Fornecedor)
                .WithMany(t => t.Endereco)
                .HasForeignKey(t => t.FornecedorCodigo);
        }
    }
}
