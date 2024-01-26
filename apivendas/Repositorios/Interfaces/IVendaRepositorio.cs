using apivendas.Models;
using System.Collections.ObjectModel;

namespace apivendas.Repositorios.Interfaces
{
    public interface IVendaRepositorio
    {
        Task<List<Venda>> Listar();
        Task<Venda?> ListarId(int id);
        Task<Venda> Criar(Venda venda);
        Task<Venda> AtualizarVenda(Venda venda);       
    }
}
