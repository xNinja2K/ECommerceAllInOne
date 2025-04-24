namespace ECommerceAllInOne.Models
{
    public class Product
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Description { get; set; }
        public required decimal Price { get; set; }
        public int Stock { get; set; }
        public required string ImagePath { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}