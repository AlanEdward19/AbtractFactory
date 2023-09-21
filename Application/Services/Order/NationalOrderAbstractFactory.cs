using Application.Services.Deliveries;
using Core.Contracts.Deliveries;
using Core.Contracts.Order;
using Core.Contracts.Payments;
using Core.Contracts.Payments.Factory;
using Core.Enums;

namespace Application.Services.Order;

public class NationalOrderAbstractFactory : IOrderAbstractFactory
{
    private readonly IDeliveryService _deliveryService;
    private readonly IPaymentServiceFactory _paymentServiceFactory;

    public NationalOrderAbstractFactory(IPaymentServiceFactory paymentServiceFactory, NationalDeliveryService deliveryService)
    {
        _paymentServiceFactory = paymentServiceFactory;
        _deliveryService = deliveryService;
    }

    public IPaymentService GetPaymentService(EPaymentMethod method) => _paymentServiceFactory.GetService(method);

    public IDeliveryService GetDeliveryService() => _deliveryService;
}