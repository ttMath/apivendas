using apivendas.Dtos.Produtos;
using apivendas.Dtos.Vendas;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apivendas.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendasController : ControllerBase
    {

        [HttpPost]
        public async Task<IActionResult> Criar(CriarVenda criarVenda)
        {
            return Ok();
        }

    }
}
