namespace ConsoleApp1.Models
{
    public class Television
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Payments { get; set; } = 0.05M;
    }
}
