using apivendas.Dtos.Produtos;
using apivendas.Dtos.Vendas;

namespace apivendas.Servicos.Interfaces
{
    public interface IVendaServico
    {
        Task<List<MostrarVendaDTO>> Listar();
        Task<MostrarVendaDTO> ListarId(int id);
        Task<MostrarVendaDTO> Criar(CriarVendaDTO criarVenda);
    }
}
