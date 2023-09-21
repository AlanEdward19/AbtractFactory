using Core.Contracts.Payments;
using Core.ValueObjects;

namespace Application.Services.Payments;

public class CreditCardService : IPaymentService
{
    public object Process(OrderValueObject model)
    {
        return "Transação aprovada [Cartão de Credito]";
    }
}