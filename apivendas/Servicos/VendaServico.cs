using apivendas.Data.Map.Automapper;
using apivendas.Dtos.Vendas;
using apivendas.Repositorios.Interfaces;
using apivendas.Servicos.Interfaces;

namespace apivendas.Servicos
{
    public class VendaServico : IVendaServico
    {
        private readonly IVendaRepositorio _vendaRepositorio;
        private readonly IEstoqueRepositorio _estoqueRepositorio;

        public VendaServico(IVendaRepositorio vendaRepositorio, IEstoqueRepositorio estoqueRepositorio)
        {
            _vendaRepositorio = vendaRepositorio;
            _estoqueRepositorio = estoqueRepositorio;
        }

        public async Task<List<MostrarVendaDTO>> Listar()
        {
            var vendas = await _vendaRepositorio.Listar();

            return vendas.ProjectedAsCollection<MostrarVendaDTO>().ToList();
        }

        public async Task<MostrarVendaDTO> ListarId(int id)
        {
            var venda = await _vendaRepositorio.ListarId(id);

            return venda.ProjectedAs<MostrarVendaDTO>();
        }

        public async Task<MostrarVendaDTO> Criar(CriarVendaDTO criarVenda)
        {
            
            var domainVenda = criarVenda.ProjectedAs<Models.Venda>();

            var vendaCriada = await _vendaRepositorio.Criar(domainVenda);

            vendaCriada = await _vendaRepositorio.ListarId(vendaCriada.Id);

            vendaCriada.VendaPagamento.ValorBruto = vendaCriada.VendaItems.Sum(x => x.Quantidade * x.Produto.Valor);
            vendaCriada.VendaPagamento.ValorTroco = vendaCriada.VendaPagamento.ValorPago - vendaCriada.VendaPagamento.ValorBruto;

            await _vendaRepositorio.AtualizarVenda(vendaCriada);

            return vendaCriada.ProjectedAs<MostrarVendaDTO>();
        }

    }
}
