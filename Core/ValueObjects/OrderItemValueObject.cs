namespace Core.ValueObjects;

public class OrderItemValueObject
{
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public decimal Price { get; set; }
}