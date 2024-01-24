using apivendas.Dtos.Produtos;
using apivendas.Dtos.Vendas;
using apivendas.Servicos.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apivendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : ControllerBase
    {
        private readonly IVendaServico _vendaServico;
        public VendasController(IVendaServico vendaServico)
        {
            _vendaServico = vendaServico;
        }
        [HttpPost]
        public async Task<IActionResult> Criar(CriarVendaDTO criarVenda)
        {
            var venda = await this._vendaServico.Criar(criarVenda);
            return Ok(venda);
        }

    }
}
