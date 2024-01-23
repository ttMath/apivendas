using apivendas.Dtos.Produtos.VendaItem;
using apivendas.Dtos.VendaPagamento;

namespace apivendas.Dtos.Vendas
{
    public class CriarVenda
    {
        public DadosPagamento DadosPagamento { get; set; }
        public IEnumerable<DadosItens> DadosItens { get; set; }
    }
}
