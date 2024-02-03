using System;
using System.Collections.Generic;

namespace DbFirst.Models
{
    public partial class OrderDetail
    {
        public int Id { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public decimal Discount { get; set; }
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
