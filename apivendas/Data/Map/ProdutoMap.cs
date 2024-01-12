using apivendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apivendas.Data.Map
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Descricao).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Valor);
            builder.Property(p => p.ValorCusto);
            builder.Property(p => p.CodigoBarra);
            builder.Property(p => p.Status)
                .HasColumnType("bit");

            builder.HasMany(p => p.Estoques)
                .WithOne(e => e.Produto)
                .HasForeignKey(e => e.IdProduto);
        }
    }
}
