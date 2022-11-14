namespace WebApplication1.Models
{
    public class Payments
    {
        public Guid Id { get; set; }
        public decimal UserPayments { get; set; }
        public Guid ComputerId { get; set; }
        public Computer? Computer{ get; set; }

        public Guid TelephoneId { get; set; }
        public Telephone? Telephone{ get; set; }
        
        public Guid TelevisionId { get; set; }
        public Television? Television{ get; set; }

    }
}
