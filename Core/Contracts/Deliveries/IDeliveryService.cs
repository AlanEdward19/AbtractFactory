using Core.ValueObjects;

namespace Core.Contracts.Deliveries;

public interface IDeliveryService
{
    object Deliver(OrderValueObject model);
}