using apivendas.Data.Enums;

namespace apivendas.Dtos.Produtos
{
    public class ProdutosDto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public decimal? ValorCusto { get; set; }
        public string? CodigoBarra { get; set; }
        public StatusProduto Status { get; set; }
    }
}
