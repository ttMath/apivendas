using apivendas.Dtos.Produtos;
using apivendas.Dtos.Vendas;
using apivendas.Models;
using apivendas.Repositorios.Interfaces;
using apivendas.Servicos.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Http.HttpResults;

namespace apivendas.Servicos
{
    public class VendaServico : IVendaServico
    {
        private readonly IVendaServico _vendaRepositorio;
        private readonly IEstoqueRepositorio _estoqueRepositorio;

        public VendaServico(IVendaRepositorio vendaRepositorio, IEstoqueRepositorio estoqueRepositorio)
        {
            _vendaRepositorio = (IVendaServico?)vendaRepositorio;
            _estoqueRepositorio = estoqueRepositorio;
        }

        public async Task<CriarVenda> Criar(CriarVenda criarVenda)
        {
            return null;
        }
    }
}
