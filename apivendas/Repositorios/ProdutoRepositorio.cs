using apivendas.Data;
using apivendas.Models;
using apivendas.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace apivendas.Repositorios
{
    
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly ApiVendasDbContext _db;
        public ProdutoRepositorio(ApiVendasDbContext apiVendasDbContext)
        {
            _db = apiVendasDbContext;
        }

        public async Task<Produto?> ListarId(int id)
        {
            var produto = await _db.Produtos.SingleOrDefaultAsync(p => p.Id == id);
            return produto;
        }

        public async Task<List<Produto>> Listar()
        {
            var produtos = await _db.Produtos.ToListAsync();
            return produtos;
        }

        public async Task<Produto> Criar(Produto produto)
        {
           await _db.Produtos.AddAsync(produto);
           await _db.SaveChangesAsync();

            return produto;
        }

        public async Task<Produto> AtualizarProduto(Produto produto)
        {
            _db.Produtos.Update(produto);
            await _db.SaveChangesAsync();

            return produto;
        }
    }
}
