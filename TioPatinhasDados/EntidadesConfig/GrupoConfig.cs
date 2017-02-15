using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using TioPatinhasDominio.Entidades;

namespace TioPatinhasDados.EntidadesConfig
{
    public class GrupoConfig : EntityTypeConfiguration<Grupo>
    {
        public GrupoConfig()
        {
            // Tabela
            ToTable("Grupo");

            // Chave primária
            HasKey(t => t.Codigo);

            // Propriedades
            Property(t => t.Codigo)
                .IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(t => t.CodigoExterno)
                .IsOptional();

            Property(t => t.Nome)
                .IsOptional();

            Property(t => t.DataExclusao)
                .IsOptional();

            Property(t => t.DataCriacaoRegistro);

            Property(t => t.DataAtualizacaoRegistro);
        }
    }
}
