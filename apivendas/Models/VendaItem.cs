namespace apivendas.Models
{
    public class VendaItem : BaseEntity
    {
        public int Quantidade { get; set; }
        public decimal ValorUnitario { get; set; }
        public Produto Produto { get; set; }

    }
}