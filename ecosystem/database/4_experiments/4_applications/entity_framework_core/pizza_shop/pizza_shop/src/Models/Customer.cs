namespace PizzaShop.Models;

public class Customer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? Address { get; set; }

    public string? Phone { get; set; }

    /*
        This is a navigation property.
        It will generate a One-to-Many ER Model.
    */
    public ICollection<Order> Orders { get; set; } = null!;
}