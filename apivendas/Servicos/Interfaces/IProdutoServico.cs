using apivendas.Dtos.Produtos;
using apivendas.Repositorios;

namespace apivendas.Servicos.Interfaces
{
    public interface IProdutoServico
    {
        Task<List<ProdutosDto>> Listar();
        Task<ProdutosDto> ListarId(int id);
        Task<ProdutosDto> Criar(CriarProdrutoDto criarProdrutoDto);
        Task<ProdutosDto> AtualizarProduto(int id, CriarProdrutoDto criarProdrutoDto);
    }
}
