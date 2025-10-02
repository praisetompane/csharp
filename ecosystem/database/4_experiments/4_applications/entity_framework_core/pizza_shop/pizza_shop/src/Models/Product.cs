using System.ComponentModel.DataAnnotations.Schema;

namespace PizzaShop.Models;

public class Product
{
    // You can use [Key] annotation for a Primary Key property not named "Id"
    public int Id { get; set; } // By convention "Id" is used a Primary Key by EFCore

    public string Name { get; set; } = null!; //null! informs compiler that we have another process that will initialize this reference type to a non-null value

    [Column(TypeName = "decimal(6,2)")]
    public decimal Price { get; set; }
}
