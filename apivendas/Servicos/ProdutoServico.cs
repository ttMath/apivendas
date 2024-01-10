using apivendas.Dtos.Produtos;
using apivendas.Models;
using apivendas.Repositorios;
using apivendas.Repositorios.Interfaces;
using apivendas.Servicos.Interfaces;
using System.Collections;
using System.Collections.Generic;

namespace apivendas.Servicos
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoServico(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }

        public async Task Criar(CriarProdrutoDto criarProdrutoDto)
        {
            Produto produto = new Produto();
            produto.Descricao = criarProdrutoDto.Descricao;
            produto.Valor = criarProdrutoDto.Valor;
            produto.ValorCusto = criarProdrutoDto.ValorCusto;
            produto.CodigoBarra = criarProdrutoDto.CodigoBarra;

            await _produtoRepositorio.Criar(produto);
        }

        public async Task<List<ProdutosDto>> Listar()
        {
            var produtos = await _produtoRepositorio.Listar();
            return produtos.Select(p => new ProdutosDto
            {
                Id = p.Id,
                CodigoBarra = p.CodigoBarra,
                Descricao = p.Descricao,
                Status = p.Status,
                Valor = p.Valor,
                ValorCusto = p.ValorCusto
            }).ToList();
        }
    }
}
