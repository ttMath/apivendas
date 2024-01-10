using apivendas.Models;

namespace apivendas.Repositorios.Interfaces
{
    public interface IProdutoRepositorio
    {
        Task<List<Produto>> Listar();
        Task<Produto?> ListarProdutoId(int id);
        Task<Produto> Criar(Produto produto);
        Task<Produto> AtualizarProduto(Produto produto, int id);       
    }
}
