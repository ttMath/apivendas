using System.ComponentModel.DataAnnotations;

namespace apivendas.Dtos.Produtos
{
    public class CriarProdrutoDto
    {
        [Required(ErrorMessage = "A DESCRIÇÃO É OBRIGATÓRIO!!")]
        public string Descricao { get; set; } = string.Empty;

        [Required(ErrorMessage = "O VALOR DO PRODUTO É OBRIGATÓRIO!!")]
        public decimal Valor { get; set; }

        public decimal ValorCusto { get; set; }
        
        public string CodigoBarra { get; set; } = string.Empty;
    }
}
