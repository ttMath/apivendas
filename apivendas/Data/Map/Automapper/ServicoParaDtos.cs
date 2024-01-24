using apivendas.Dtos.Produtos;
using apivendas.Dtos.Produtos.VendaItem;
using apivendas.Dtos.VendaPagamento;
using apivendas.Dtos.Vendas;
using apivendas.Models;
using AutoMapper;

namespace apivendas.Data.Map.Automapper
{
    public class ServicoParaDtos : Profile
    {
        public ServicoParaDtos()
        {
            CreateMap<Produto, ProdutosDto>();
            CreateMap<CriarProdrutoDto, Produto>();
            CreateMap<DadosItensDTO, VendaItem>();
            CreateMap<DadosPagamentoDTO, VendaPagamento>();

            CreateMap<CriarVendaDTO, Venda>();

            CreateMap<Venda, MostrarVendaDTO>();
            CreateMap<VendaPagamento, MostrarVendaPagamentoDTO>();
            CreateMap<VendaItem, MostrarVendaItemDTO>()
                .ForMember(x => x.ValorVenda, opt => opt.MapFrom(x => x.Quantidade * x.Produto.Valor));
            CreateMap<Produto, MostrarProdutoDTO>();

        }
    }
}
