namespace ConsoleApp1.Models
{
    public class Computer
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public decimal Payments { get; set; } = 0.04M;
    }
}
