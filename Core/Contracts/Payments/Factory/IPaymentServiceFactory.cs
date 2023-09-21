using Core.Enums;

namespace Core.Contracts.Payments.Factory;

public interface IPaymentServiceFactory
{
    IPaymentService GetService(EPaymentMethod paymentMethod);
}