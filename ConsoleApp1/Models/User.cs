namespace ConsoleApp1.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string PhoneNumber { get; set; }
        public decimal Debtor { get; set; }
        public Guid ProductId { get; set; }
        public Product Product { get; set; }
    }
}
