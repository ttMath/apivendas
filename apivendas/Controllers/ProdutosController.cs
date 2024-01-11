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

        [HttpGet("{id}")]
        public async Task<IActionResult> ListarId(int id)
        {
            var produtoDto = await _produtoServico.ListarId(id);
            return Ok(produtoDto);
        }

        [HttpPost]
        public async Task<IActionResult> Criar([FromBody] CriarProdrutoDto criarProdruto)
        {
            var produto = await _produtoServico.Criar(criarProdruto);
            return Ok(produto);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> AtualizarProduto(int id, [FromBody] CriarProdrutoDto prodrutoDto)
        {
            var produtoAtualizado = await _produtoServico.AtualizarProduto(id, prodrutoDto);

            return Ok(produtoAtualizado);
        }
    }
}
