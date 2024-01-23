using apivendas.Data;
using apivendas.Models;
using apivendas.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace apivendas.Repositorios
{
    public class EstoqueRepositorio : IEstoqueRepositorio
    {
        private readonly ApiVendasDbContext _db;

        public EstoqueRepositorio(ApiVendasDbContext apiVendasDbContext)
        {
            _db = apiVendasDbContext;
        }
        public async Task<Estoque> ObterOuCriarEstoque(int idProduto)
        {
            var estoqueExistente = await _db.Estoques.FirstOrDefaultAsync(e => e.ProdutoId == idProduto);

            if (estoqueExistente != null)
            {
                return estoqueExistente;
            }
            else
            {
                var novoEstoque = new Estoque { ProdutoId = idProduto };
                _db.Estoques.Add(novoEstoque);
                await _db.SaveChangesAsync();

                return novoEstoque;
            }
        }
    }
}
