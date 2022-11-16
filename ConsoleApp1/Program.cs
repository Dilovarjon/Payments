using ConsoleApp1;
using ConsoleApp1.Models;

List<User> users = new();
List<ProductType> productTypes = new();
var productType = new ProductType
{
    Id = Guid.NewGuid(),
    Name = "computer",
    Percentage = 0.03M,
    AdditionalPercentage = 0.03M,
    FromRangeInstallment = 3,
    ToRangeInstallment = 12
};
productTypes.Add(productType);
var products = new List<Product>
{
    new Product {Id = Guid.NewGuid(), Name = "computer", ProductType = productType }
};

var payment = new PaymentsService();
var user = payment.Payment(products.FirstOrDefault(), 3000, "12345678", 3);
users.Add(user);
Console.WriteLine($"{user.Id} - {user.ProductId} - {user.Debtor} - {user.PhoneNumber} - {user.Product.Name}");
var Installment = new InstallmentPayments();
users.Append(Installment.InstallmentPayment(300,user));
