using apivendas.Dtos.Produtos;
using apivendas.Servicos;
using apivendas.Servicos.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace apivendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutosController : ControllerBase
    {
        private readonly IProdutoServico _produtoServico;
        public ProdutosController(IProdutoServico produtoServico)
        {
            _produtoServico = produtoServico;
        }

        [HttpGet]
        public async Task<ActionResult<List<ProdutosDto>>> Listar()
        {
            var produtos = await _produtoServico.Listar();
            return Ok(produtos);
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] CriarProdrutoDto criarProdruto)
        {
            await _produtoServico.Criar(criarProdruto);
            return Ok();
        }
    }
}
