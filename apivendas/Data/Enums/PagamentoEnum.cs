using System.ComponentModel;

namespace apivendas.Data.Enums
{
        public enum PagamentoEnum
        {
            [Description("Dinheiro")]
            Ativo = 1,

            [Description("Pix")]
            Pix = 2,

            [Description("Cartão")]
            Cartao = 3
    }
}
