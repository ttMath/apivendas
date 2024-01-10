using apivendas.Data.Map;
using apivendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace apivendas.Data
{
    public class ApiVendasDbContext : DbContext
    {
        public ApiVendasDbContext(DbContextOptions<ApiVendasDbContext> options)
          : base(options)
        {
        }

        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoMap());

            base.OnModelCreating(modelBuilder);
        }
    }
}
