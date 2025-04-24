namespace ECommerceAllInOne.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }
        public DateTime OrderDate { get; set; }
        public required string Status { get; set; }
        // relationship:
        public User? User { get; set; }
        public Product? Product { get; set; }
    }
}