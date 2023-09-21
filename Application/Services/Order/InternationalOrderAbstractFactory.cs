using Application.Services.Deliveries;
using Application.Services.Payments;
using Core.Contracts.Deliveries;
using Core.Contracts.Order;
using Core.Contracts.Payments;
using Core.Enums;

namespace Application.Services.Order;

public class InternationalOrderAbstractFactory : IOrderAbstractFactory
{
    private readonly IPaymentService _paymentService;
    private readonly IDeliveryService _deliveryService;

    public InternationalOrderAbstractFactory(CreditCardService paymentService, InternationalDeliveryService deliveryService)
    {
        _paymentService = paymentService;
        _deliveryService = deliveryService;
    }

    public IPaymentService GetPaymentService(EPaymentMethod method) => _paymentService;

    public IDeliveryService GetDeliveryService() => _deliveryService;
}