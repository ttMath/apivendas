using apivendas.Data.Enums;

namespace apivendas.Dtos.VendaPagamento
{
    public class DadosPagamentoDTO
    {
        public PagamentoEnum IdFinalizadora { get; set; }
        public decimal ValorPago { get; set; }
    }
}
