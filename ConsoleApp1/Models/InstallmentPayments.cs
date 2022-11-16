namespace ConsoleApp1.Models
{
    public class InstallmentPayments
    {
        public Guid Id { get; set; }
        public DateTime DateTimes { get; set; } = DateTime.Now;
        public Guid UserId { get; set; }
        public User User { get; set; }

        public User InstallmentPayment(decimal money,User user)
        {
            user.Debtor = user.Debtor - money;
            Console.WriteLine($"Время оплаты:{this.DateTimes} - Остались должны :{user.Debtor}");
            return user;
        }
    }
}
