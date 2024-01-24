using apivendas.Dtos.Produtos.VendaItem;
using apivendas.Dtos.VendaPagamento;

namespace apivendas.Dtos.Vendas
{
    public class CriarVendaDTO
    {
        public DadosPagamentoDTO VendaPagamento { get; set; }
        public IEnumerable<DadosItensDTO> VendaItems { get; set; }
    }
}
