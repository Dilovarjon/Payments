namespace WebApplication1.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string phoneNumber { get; set; }
        
        public Guid PaymentsId { get; set; }
        public Payments Payments { get; set; }
    }
}
