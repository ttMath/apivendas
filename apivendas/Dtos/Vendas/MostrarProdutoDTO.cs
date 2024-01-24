using System.ComponentModel.DataAnnotations;

namespace apivendas.Dtos.Vendas
{
    public class MostrarProdutoDTO : BaseDTO
    {
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
    }
}