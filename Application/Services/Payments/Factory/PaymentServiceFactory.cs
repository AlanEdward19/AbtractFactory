using Core.Contracts.Payments;
using Core.Contracts.Payments.Factory;
using Core.Enums;

namespace Application.Services.Payments.Factory;

public class PaymentServiceFactory : IPaymentServiceFactory
{
    private readonly CreditCardService _creditCardService;
    private readonly PaymentSlipService _paymentSlipService;

    public PaymentServiceFactory(CreditCardService creditCardService, PaymentSlipService paymentSlipService)
    {
        _creditCardService = creditCardService;
        _paymentSlipService = paymentSlipService;
    }

    public IPaymentService GetService(EPaymentMethod paymentMethod) => paymentMethod switch
    {
        EPaymentMethod.CreditCard => _creditCardService,
        EPaymentMethod.PaymentSlip => _paymentSlipService
    };
}