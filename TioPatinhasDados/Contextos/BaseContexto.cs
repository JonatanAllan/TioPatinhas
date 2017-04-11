using System;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TioPatinhasDados.EntidadesConfig;
using TioPatinhasDominio.Entidades;
using TioPatinhasRecursos.TioPatinhas;

namespace TioPatinhasDados.Contextos
{
    public class BaseContexto : DbContext
    {
        static BaseContexto()
        {
            Database.SetInitializer<BaseContexto>(null);
        }

        public BaseContexto() 
            : base(BancosDados.TioPatinhas(BancosDados.TipoConexao.Local))
        {
            Configuration.ProxyCreationEnabled = false;
            Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<Classe> Classes { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Familia> Familias { get; set; }
        public DbSet<Fornecedor> Fornecedores { get; set; }
        public DbSet<Grupo> Grupos { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<PedidoItem> PedidoItens { get; set; }
        public DbSet<PedidoStatus> PedidoStatus { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<ProdutoFornecedor> ProdutoFornecedores { get; set; }
        public DbSet<SubGrupoProduto> SubGrupoProdutos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Properties<string>().Configure(p => p.HasColumnType("VARCHAR"));
            modelBuilder.Properties<string>().Configure(p => p.HasMaxLength(120));

            modelBuilder.Configurations.Add(new ClasseConfig());
            modelBuilder.Configurations.Add(new EnderecoConfig());
            modelBuilder.Configurations.Add(new FamiliaConfig());
            modelBuilder.Configurations.Add(new FornecedorConfig());
            modelBuilder.Configurations.Add(new GrupoConfig());
            modelBuilder.Configurations.Add(new MarcaConfig());
            modelBuilder.Configurations.Add(new PedidoConfig());
            modelBuilder.Configurations.Add(new PedidoStatusConfig());
            modelBuilder.Configurations.Add(new PedidoItemConfig());
            modelBuilder.Configurations.Add(new ProdutoConfig());
            modelBuilder.Configurations.Add(new ProdutoFornecedorConfig());
            modelBuilder.Configurations.Add(new SubGrupoProdutoConfig());
        }

        public override int SaveChanges()
        {
            foreach (var entry in ChangeTracker.Entries())
            {
                if (entry.State == EntityState.Added)
                {
                    entry.Property("DataCriacaoRegistro").CurrentValue = DateTime.Now;
                    entry.Property("DataAtualizacaoRegistro").CurrentValue = DateTime.Now;
                }

                if (entry.State != EntityState.Modified) continue;

                entry.Property("DataCriacaoRegistro").IsModified = false;
                entry.Property("DataAtualizacaoRegistro").CurrentValue = DateTime.Now;
            }
            return base.SaveChanges();
        }
    }
}