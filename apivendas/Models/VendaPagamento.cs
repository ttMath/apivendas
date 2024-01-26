using apivendas.Data.Enums;

namespace apivendas.Models
{
    public class VendaPagamento : BaseEntity
    {
        public PagamentoEnum IdFinalizadora { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorTroco { get; set; }
    }
}