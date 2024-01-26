using apivendas.Data.Enums;

namespace apivendas.Dtos.Vendas
{
    public class MostrarVendaPagamentoDTO
    {
        public PagamentoEnum IdFinalizadora { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorTroco { get; set; }
    }
}