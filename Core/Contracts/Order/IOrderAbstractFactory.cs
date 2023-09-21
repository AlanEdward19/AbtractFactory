using Core.Contracts.Deliveries;
using Core.Contracts.Payments;
using Core.Enums;
namespace Core.Contracts.Order;

public interface IOrderAbstractFactory
{
    IPaymentService GetPaymentService(EPaymentMethod method);
    IDeliveryService GetDeliveryService();
}