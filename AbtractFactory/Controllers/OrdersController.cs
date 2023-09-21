using Application.Services.Order;
using Core.Contracts.Order;
using Core.Contracts.Payments.Factory;
using Core.ValueObjects;
using Microsoft.AspNetCore.Mvc;

namespace AbtractFactory.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IPaymentServiceFactory _paymentServiceFactory;

        public OrdersController(IPaymentServiceFactory paymentServiceFactory)
        {
            _paymentServiceFactory = paymentServiceFactory;
        }

        [HttpPost]
        public IActionResult Post([FromServices] InternationalOrderAbstractFactory internationalOrderAbstractFactory,
            [FromServices] NationalOrderAbstractFactory nationalOrderAbstractFactory, OrderValueObject model)
        {
            IOrderAbstractFactory orderAbstractFactory = model.IsInternational != null && model.IsInternational.Value
                ? internationalOrderAbstractFactory
                : nationalOrderAbstractFactory;

            var paymentResult = orderAbstractFactory.GetPaymentService(model.PaymentInfo.PaymentMethod).Process(model);

            var deliverResult = orderAbstractFactory.GetDeliveryService().Deliver(model);

            return Ok(new
            {
                PaymentResult = paymentResult,
                DeliverStatus = deliverResult
            });
        }
    }
}
