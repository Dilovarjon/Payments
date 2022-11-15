namespace ConsoleApp1.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Guid InstallmentTypeId { get; set; }
        public ProductType ProductType { get; set; }
        public decimal CalculatePayment(int rangePayments)
        {
            this.ProductType.RangeInstallment = rangePayments;
            if (this.ProductType.RangeInstallment > this.ProductType.ToRangeInstallment)
            {
                switch (this.ProductType.RangeInstallment)
                {
                    case 3:
                        this.ProductType.Percentage = this.ProductType.Percentage + this.ProductType.AdditionalPercentage;
                        break;
                    case 6:
                        this.ProductType.Percentage = this.ProductType.Percentage + this.ProductType.AdditionalPercentage;
                        break;
                    case 9:
                        this.ProductType.Percentage = this.ProductType.Percentage + this.ProductType.AdditionalPercentage;
                        break;
                    case 12:
                        this.ProductType.Percentage = this.ProductType.Percentage + this.ProductType.AdditionalPercentage;
                        break;
                    case 18:
                        this.ProductType.Percentage = this.ProductType.Percentage + this.ProductType.AdditionalPercentage;
                        break;
                    case 24:
                        this.ProductType.Percentage = this.ProductType.Percentage + this.ProductType.AdditionalPercentage;
                        break;
                }
            }
            return this.ProductType.Percentage;
        }

    }
}
