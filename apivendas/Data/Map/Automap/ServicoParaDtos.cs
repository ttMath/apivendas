using apivendas.Dtos.Produtos;
using apivendas.Models;
using apivendas.Repositorios;
using apivendas.Servicos;
using AutoMapper;

namespace apivendas.Data.Map.Automap
{
    public class ServicoParaDtos : Profile
    {
        public ServicoParaDtos()
        {
            CreateMap<Produto, ProdutosDto>().ReverseMap();
            CreateMap<Produto, CriarProdrutoDto>().ReverseMap();
        }
    }
}
