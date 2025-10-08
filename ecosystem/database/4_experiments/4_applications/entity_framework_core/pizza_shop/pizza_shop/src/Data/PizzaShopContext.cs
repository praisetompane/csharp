using Microsoft.EntityFrameworkCore;
using PizzaShop.Models;

namespace PizzaShop.Data;

/*
    This is the critical piece that Entity Framework uses to determine
    the migrations to create.
*/
public class PizzaShopContext : DbContext
{
    public DbSet<Customer> Customers { get; set; } = null!;

    public DbSet<Product> Products { get; set; } = null!;

    public DbSet<Order> Orders { get; set; } = null!;

    public DbSet<OrderDetail> OrderDetails { get; set; } = null!;

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // Never hard code in PROD of-course
        optionsBuilder.UseSqlServer("Server=mssql_server_local,1433; Database=app_pizza_shop; User Id=sa; Password=example_123; Encrypt=false; TrustServerCertificate=true; MultipleActiveResultSets=true;");
    }
}