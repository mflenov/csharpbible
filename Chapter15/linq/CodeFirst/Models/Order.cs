namespace CodeFirst.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public DateTime Created { get; set; }
        public DateTime Modified { get; set; }
    }
}
