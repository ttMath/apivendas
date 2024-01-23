using apivendas.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace apivendas.Data.Map
{
    public class VendaPagamentoMap : IEntityTypeConfiguration<VendaPagamento>
    {
        public void Configure(EntityTypeBuilder<VendaPagamento> builder)
        {
        }
    }
}
