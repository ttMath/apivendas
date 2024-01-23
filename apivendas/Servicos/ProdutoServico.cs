using apivendas.Dtos.Produtos;
using apivendas.Models;
using apivendas.Repositorios.Interfaces;
using apivendas.Servicos.Interfaces;
using AutoMapper;

namespace apivendas.Servicos
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IVendaRepositorio _produtoRepositorio;
        private readonly IEstoqueRepositorio _estoqueRepositorio;
        private readonly IMapper _mapper;
        public ProdutoServico(IVendaRepositorio produtoRepositorio, IMapper mapper, IEstoqueRepositorio estoqueRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
            _mapper = mapper;
            _estoqueRepositorio = estoqueRepositorio;
        }

        public async Task<List<ProdutosDto>> Listar()
        {
            var produtos = await _produtoRepositorio.Listar();
            var produtosDto = _mapper.Map<List<ProdutosDto>>(produtos);

            return produtosDto;
        }
        public async Task<ProdutosDto> ListarId(int id)
        {
            var produto = await _produtoRepositorio.ListarId(id);

            if (produto == null)
            {
                return null;
            }

            var produtoDto = _mapper.Map<ProdutosDto>(produto);

            return produtoDto;
        }

        public async Task<ProdutosDto> Criar(CriarProdrutoDto criarProdrutoDto)
        {
            var produto = _mapper.Map<Produto>(criarProdrutoDto);

            produto = await _produtoRepositorio.Criar(produto);

            var estoqueExistente = await _estoqueRepositorio.ObterOuCriarEstoque(produto.Id);

            estoqueExistente.ProdutoId = produto.Id;

            return _mapper.Map<ProdutosDto>(produto);
        }

        public async Task<ProdutosDto> AtualizarProduto(int id, CriarProdrutoDto prodrutoDto)
        {
            var produtoExistente = await _produtoRepositorio.ListarId(id);

            if (produtoExistente == null)
            {
                return null;
            }

            _mapper.Map(prodrutoDto, produtoExistente);

            await _produtoRepositorio.AtualizarProduto(produtoExistente);

            return _mapper.Map<ProdutosDto>(produtoExistente);
        }
    }
}
