namespace ECommerceAllInOne.Models
{
    public class User
    {
        // id, name, email, password, role
        public int Id { get; set; }
        public required string Username { get; set; }
        public required string PasswordHash { get; set; }
        public required string Email { get; set; }
        public required string Role { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}