using Core.Contracts.Deliveries;
using Core.ValueObjects;

namespace Application.Services.Deliveries;

public class InternationalDeliveryService : IDeliveryService
{
    public object Deliver(OrderValueObject model)
    {
        return "Entregue [Internacional]";
    }
}