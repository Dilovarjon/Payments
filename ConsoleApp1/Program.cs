using ConsoleApp1;
using ConsoleApp1.Models;

List<User> users = new();
List<DTO> dTOs = new();
List<Television> televisions = new();
List<Payments> payments = new();
List<Computer> computer = new();
List<Telephone> telephones = new();

var com = new Computer();
com.Id = new Guid();
com.Name = "qwe";
computer.Add(com);
var pay = new PaymentsService();
var dto = new DTO();
dTOs.Add(dto);
dto.Computer = com; 
dto.PhoneNumber = "1234567890";
dto.Sum = 3000;
dto.RangePayments = 3;
dto.Computer.Id = new Guid();
users.Add(pay.Payment(dto));

var use = users.FirstOrDefault();
Console.WriteLine($"{use.Name} - {use.Id} - {use.Payment} - {use.DTO} - {use.phoneNumber} " +
    $"- {use.DTO?.Computer?.Id} - { use.DTO.Computer.Name} - {use.DTO.RangePayments}");