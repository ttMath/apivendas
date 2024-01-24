using apivendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apivendas.Data.Map
{
    public class VendaItemMap : IEntityTypeConfiguration<VendaItem>
    {
        public void Configure(EntityTypeBuilder<VendaItem> builder)
        {
            builder.HasOne(x => x.Produto).WithMany().HasForeignKey(x => x.ProdutoId);
        }
    }
}
