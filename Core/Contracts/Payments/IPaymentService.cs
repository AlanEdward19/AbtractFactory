using Core.ValueObjects;

namespace Core.Contracts.Payments;

public interface IPaymentService
{
    object Process(OrderValueObject model);
}