﻿using apivendas.Dtos.Produtos;
using apivendas.Models;
using apivendas.Repositorios.Interfaces;
using apivendas.Servicos.Interfaces;
using AutoMapper;

namespace apivendas.Servicos
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        private readonly IMapper _mapper;
        public ProdutoServico(IProdutoRepositorio produtoRepositorio, IMapper mapper)
        {
            _produtoRepositorio = produtoRepositorio;
            _mapper = mapper;
        }

        public async Task<List<ProdutosDto>> Listar()
        {
            var produtos = await _produtoRepositorio.Listar();
            var produtosDto = _mapper.Map<List<ProdutosDto>>(produtos);

            return produtosDto;
        }
        public async Task<ProdutosDto> ListarId(int id)
        {
            var produto = await _produtoRepositorio.ListarId(id);

            if (produto == null)
            {
                return null;
            }

            var produtoDto = _mapper.Map<ProdutosDto>(produto);

            return produtoDto;
        }

        public async Task<ProdutosDto> Criar(CriarProdrutoDto criarProdrutoDto)
        {
            var produto = _mapper.Map<Produto>(criarProdrutoDto);

            await _produtoRepositorio.Criar(produto);

            return _mapper.Map<ProdutosDto>(produto);
        }

        public async Task<ProdutosDto> AtualizarProduto(int id, CriarProdrutoDto prodrutoDto)
        {
            var produtoExistente = await _produtoRepositorio.ListarId(id);

            if (produtoExistente == null)
            {
                return null;
            }

            _mapper.Map(prodrutoDto, produtoExistente);

            await _produtoRepositorio.AtualizarProduto(produtoExistente);

            return _mapper.Map<ProdutosDto>(produtoExistente);
        }
    }
}