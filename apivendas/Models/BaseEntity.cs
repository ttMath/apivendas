using System.ComponentModel.DataAnnotations;

namespace apivendas.Models
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            this.CriadoEm = DateTime.Now;
        }
        [Key]
        public int Id { get; set; }

        public DateTime CriadoEm { get; init; }
    }
}