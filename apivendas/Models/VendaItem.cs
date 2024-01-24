namespace apivendas.Models
{
    public class VendaItem : BaseEntity
    {
        public int Quantidade { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
    }
}