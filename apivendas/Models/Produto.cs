using apivendas.Data.Enums;
using System.ComponentModel.DataAnnotations;

namespace apivendas.Models
{
    public class Produto
    {
        public Produto()
        {
            Status = true;
        }
        public int Id { get; set; }
        [StringLength(100), Required]
        public string Descricao { get; set; }
        public decimal Valor { get; set; }
        public decimal? ValorCusto { get; set; }
        public string? CodigoBarra { get; set; }
        public bool Status { get; set; } 

        public ICollection<Estoque> Estoques { get; set; }
    }
}
