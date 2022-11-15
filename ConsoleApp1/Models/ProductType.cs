namespace ConsoleApp1.Models
{
    public class ProductType
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int FromRangeInstallment { get; set; }
        public int ToRangeInstallment { get; set; }
        public int RangeInstallment { get; set; }
        public decimal Percentage { get; set; }
        public decimal AdditionalPercentage { get; set; }
    }
}
