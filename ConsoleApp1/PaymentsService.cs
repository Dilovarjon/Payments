using ConsoleApp1.Models;

namespace ConsoleApp1
{
    public class PaymentsService
    {

        public User Payment(DTO dto)
        {
            var user = new User();

            user.DTO = dto;
            user.Name = "Andrey";
            user.phoneNumber = dto.PhoneNumber;


            if (dto.Television != null)
            {
                switch (dto.RangePayments)
                {
                    case 3:
                        dto.Television!.Payments = default;
                        break;
                    case 6:
                        dto.Television!.Payments = default;
                        break;
                    case 9:
                        dto.Television!.Payments = default;
                        break;
                    case 12:
                        dto.Television!.Payments = default;
                        break;
                    case 18:
                        dto.Television!.Payments = default;
                        break;
                    case 24:
                        dto.Television!.Payments = dto.Television.Payments * 2;
                        break;
                    default:
                        throw new Exception("Ошибка ввода Диапазона");
                }
                user.Payment = (dto.Sum * dto.Television.Payments) + dto.Sum;
            }
            else if (dto.Telephone != null)
            {
                switch (dto.RangePayments)
                {
                    case 3:
                        dto.Telephone!.Payments = default;
                        break;
                    case 6:
                        dto.Telephone!.Payments = default;
                        break;
                    case 9:
                        dto.Telephone!.Payments = default;
                        break;
                    case 12:
                        dto.Telephone!.Payments = dto.Telephone.Payments * 2;
                        break;
                    case 18:
                        dto.Telephone!.Payments = dto.Telephone.Payments * 2;
                        break;
                    case 24:
                        dto.Telephone!.Payments = dto.Telephone.Payments * 2;
                        break;
                    default:
                        throw new Exception("Ошибка ввода Диапазона");
                }
                user.Payment = (dto.Sum * dto.Telephone.Payments) + dto.Sum;
            }
            else if (dto.Computer != null)
            {
                switch (dto.RangePayments)
                {
                    case 3:
                        dto.Computer!.Payments = default;
                        break;
                    case 6:
                        dto.Computer!.Payments = default;
                        break;
                    case 9:
                        dto.Computer!.Payments = default;
                        break;
                    case 12:
                        dto.Computer!.Payments = default;
                        break;
                    case 18:
                        dto.Computer!.Payments = dto.Computer.Payments * 2;
                        break;
                    case 24:
                        dto.Computer!.Payments = dto.Computer.Payments * 2;
                        break;
                    default:
                        throw new Exception("Ошибка ввода Диапазона");
                }
                user.Payment = (dto.Sum * dto.Computer.Payments) + dto.Sum;
            }
            else
                throw new Exception("ничего не было взято");
            
            return user;
        }
    }
}
