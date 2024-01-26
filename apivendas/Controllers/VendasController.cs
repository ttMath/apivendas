using apivendas.Dtos.Produtos;
using apivendas.Dtos.Vendas;
using apivendas.Servicos;
using apivendas.Servicos.Interfaces;
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

        [HttpGet]
        public async Task<ActionResult<List<MostrarVendaDTO>>> Listar()
        {
            var vendas = await _vendaServico.Listar();
            return Ok(vendas);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> ListarId(int id)
        {
            var venda = await _vendaServico.ListarId(id);
            return Ok(venda);
        }

        [HttpPost]
        public async Task<IActionResult> Criar(CriarVendaDTO criarVenda)
        {
            var venda = await this._vendaServico.Criar(criarVenda);
            return Ok(venda);
        }

    }
}
