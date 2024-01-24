namespace apivendas.Dtos.Vendas
{
    public class MostrarVendaPagamentoDTO : BaseDTO
    {
        public int IdFinalizadora { get; set; }
        public decimal ValorBruto { get; set; }
        public decimal ValorPago { get; set; }
        public decimal ValorTroco { get; set; }
    }
}