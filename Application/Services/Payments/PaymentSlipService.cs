using Core.Contracts.Payments;
using Core.ValueObjects;

namespace Application.Services.Payments;

public class PaymentSlipService : IPaymentService
{
    public object Process(OrderValueObject model)
    {
        return "Transação aprovada [Boleto]";
    }
}