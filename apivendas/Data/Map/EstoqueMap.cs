using apivendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apivendas.Data.Map
{
    public class EstoqueMap : IEntityTypeConfiguration<Estoque>
    {
        public void Configure(EntityTypeBuilder<Estoque> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.IdProduto).IsRequired();
            builder.Property(e => e.Quantidade).IsRequired();

            builder.HasOne(e => e.Produto)
                .WithMany(p => p.Estoques).
                HasForeignKey(e => e.IdProduto);
        }
    }
}
