using Microsoft.EntityFrameworkCore.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace apivendas.Models
{
    public class Venda : BaseEntity
    {
        public ICollection<VendaItem> vendaItems { get; set; }
        public VendaPagamento VendaPagamento { get; set; }
    }
}
