using apivendas.Models;

namespace apivendas.Repositorios.Interfaces
{
    public interface IEstoqueRepositorio
    {
        Task<Estoque> ObterOuCriarEstoque(int idProduto);
    }
}
