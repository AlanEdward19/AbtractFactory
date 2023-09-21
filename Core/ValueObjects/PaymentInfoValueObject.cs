using Core.Enums;

namespace Core.ValueObjects;

public class PaymentInfoValueObject
{
    public EPaymentMethod PaymentMethod { get; set; }
    public string CardNumber { get; set; }
    public string FullName { get; set; }
    public string ExpirationDate { get; set; }
    public string Cvv { get; set; }
}