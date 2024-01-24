namespace apivendas.Dtos.Vendas
{
    public class MostrarVendaDTO : BaseDTO
    {
        public ICollection<MostrarVendaItemDTO> VendaItems { get; set; }
        public MostrarVendaPagamentoDTO VendaPagamento { get; set; }
    }
}
