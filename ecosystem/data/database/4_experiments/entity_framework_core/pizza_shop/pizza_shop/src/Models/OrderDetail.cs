namespace PizzaShop.Models;

public class OrderDetail
{
    public int Id { get; set; }

    public int Quantity { get; set; }


    /*
        This is a Foreign Key.
        EFCore willl generate this automatically if not explicitly define.
        It will be created as a shadow property.
    */
    public int ProductId { get; set; }


    /*
        This is a Foreign Key.
        EFCore willl generate this automatically if not explicitly define.
        It will be created as a shadow property.
    */
    public int OrderId { get; set; }

    /*
        This is a navigation property.
        It will generate a One-to-Many ER Model.
    */
    public OrderDetail Order { get; set; } = null!;

    /*
        This is a navigation property.
        It will generate a One-to-Many ER Model.
    */
    public Product Product { get; set; } = null!;
}