namespace PizzaShop.Models;

public class Order
{
    public int Id { get; set; }

    public DateTime OrderPlaced { get; set; }

    public DateTime? OrderFulfilled { get; set; }

    /*
        This is a Foreign Key.
        EFCore willl generate this automatically if not explicitly define.
        It will be created as a shadow property.
    */
    public int CustomerId { get; set; }

    /*
        This is a navigation property.
        Indicates each Order has one Customer
    */
    public Customer Customer { get; set; } = null!;

    /*
        This is a navigation property.
        It will generate a One-to-Many ER Model.
    */
    public ICollection<OrderDetail> OrderDetails { get; set; } = null!;

}