namespace Core.ValueObjects;

public class CustomerValueObject
{
    public Guid Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string Document { get; set; }
}