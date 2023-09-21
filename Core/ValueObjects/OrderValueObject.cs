namespace Core.ValueObjects;

public class OrderValueObject
{
    public CustomerValueObject Customer { get; set; }
    public List<OrderItemValueObject> Items { get; set; }
    public DeliveryAddressValueObject DeliveryAddress { get; set; }
    public PaymentAddressValueObject PaymentAddress { get; set; }
    public PaymentInfoValueObject PaymentInfo { get; set; }
    public bool? IsInternational { get; set; }
}