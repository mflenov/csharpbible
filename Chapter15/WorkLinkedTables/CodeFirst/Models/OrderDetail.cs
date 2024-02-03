using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    public class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Discount { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }

        public int ProductId { get; set; }
        public Product Product { get; set; } = null!;
        public Order Order { get; set; } = null!;
    }
}
