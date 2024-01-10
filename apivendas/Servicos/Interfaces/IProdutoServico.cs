using apivendas.Dtos.Produtos;
using apivendas.Repositorios;

namespace apivendas.Servicos.Interfaces
{
    public interface IProdutoServico
    {
        Task<List<ProdutosDto>> Listar();
        Task Criar(CriarProdrutoDto criarProdrutoDto);
        
    }
}
