using apivendas.Dtos.Vendas;

namespace apivendas.Servicos.Interfaces
{
    public interface IVendaServico
    {
      Task<MostrarVendaDTO> Criar(CriarVendaDTO criarVenda);
    }
}
