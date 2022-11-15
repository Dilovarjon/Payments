namespace ConsoleApp1.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string phoneNumber { get; set; }
        public decimal Payment { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
