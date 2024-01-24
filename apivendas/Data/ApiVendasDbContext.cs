using apivendas.Data.Map;
using apivendas.Models;
using Microsoft.EntityFrameworkCore;

namespace apivendas.Data
{
    public class ApiVendasDbContext : DbContext
    {
        public ApiVendasDbContext(DbContextOptions<ApiVendasDbContext> options)
          : base(options)
        {
        }

        public DbSet<Venda> Vendas { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<VendaPagamento> VendaPagamentos { get; set; }
        public DbSet<VendaItem> VendaItems { get; set; }
        public DbSet<Estoque> Estoques { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VendaMap());
            modelBuilder.ApplyConfiguration(new VendaPagamentoMap());
            modelBuilder.ApplyConfiguration(new ProdutoMap());
            modelBuilder.ApplyConfiguration(new VendaItemMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
