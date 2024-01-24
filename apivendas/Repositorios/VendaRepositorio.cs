using apivendas.Repositorios.Interfaces;
using apivendas.Data;
using apivendas.Models;
using Microsoft.EntityFrameworkCore;

namespace apivendas.Repositorios
{

    public class VendaRepositorio : IVendaRepositorio
    {
        private readonly ApiVendasDbContext _db;
        public VendaRepositorio(ApiVendasDbContext apiVendasDbContext)
        {
            _db = apiVendasDbContext;
        }

        public async Task<Venda?> ListarId(int id)
        {
            var venda = await _db.Vendas
                .Include(x=>x.VendaPagamento)
                .Include(x=>x.VendaItems).ThenInclude(x=>x.Produto)
                .FirstOrDefaultAsync(p => p.Id == id);
            return venda;
        }

        public async Task<List<Venda>> Listar()
        {
            var vendas = await _db.Vendas.ToListAsync();
            return vendas;
        }

        public async Task<Venda> Criar(Venda venda)
        {
            await _db.Vendas.AddAsync(venda);
            await _db.SaveChangesAsync();

            return venda;
        }

        public async Task<Venda> AtualizarVenda(Venda venda)
        {
            _db.Vendas.Update(venda);
            await _db.SaveChangesAsync();

            return venda;
        }
    }
}
