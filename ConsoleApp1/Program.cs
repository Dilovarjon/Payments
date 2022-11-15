using ConsoleApp1;
using ConsoleApp1.Models;

List<User> users = new();
List<Television> televisions = new();
List<Payments> payments = new();
List<Computer> computer = new();
List<Telephone> telephones = new();
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

Console.WriteLine($"{user.Id} - {user.ProductId} - {user.Payment} - {user.phoneNumber} - {user.Product.Name}");