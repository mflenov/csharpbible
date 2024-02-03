using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Name { get; set; } = null!;
        [Column(TypeName = "ntext")]
        public string Description { get; set; } = null!;
        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
