using ConsoleApp1.Models;

namespace ConsoleApp1
{
    public class PaymentsService
    {
        public User Payment(Product tovar, decimal sum, string phoneNumber, int rangePayments)
        {
            var user = new User();
            
            var paymentTovar = tovar.CalculatePayment(rangePayments);
            user.Id = new Guid();
            user.phoneNumber = phoneNumber;
            user.Payment = sum + (sum * paymentTovar);
            user.Product = tovar;
            return user;
        }
    }
}
