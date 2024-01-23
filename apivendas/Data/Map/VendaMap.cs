using apivendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apivendas.Data.Map
{
    public class VendaMap : IEntityTypeConfiguration<Venda>
    {
        public void Configure(EntityTypeBuilder<Venda> builder) 
        {
            builder.HasOne(x => x.VendaPagamento).WithOne().HasForeignKey<VendaPagamento>(x => x.Id);
        }
    }
}
