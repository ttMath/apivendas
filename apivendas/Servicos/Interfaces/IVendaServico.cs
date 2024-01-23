using apivendas.Dtos.Vendas;

namespace apivendas.Servicos.Interfaces
{
    public interface IVendaServico
    {
      Task<CriarVenda> Criar(CriarVenda criarVenda);
    }
}
