using System.Linq;
using ECommerce.Data;
using ECommerce.Models;

public static class DbInitializer
{
    public static void Initialize(ECommerceDbContext context)
    {
        // Ensure the database is created
        context.Database.EnsureCreated();

        // Look for any existing products
        if (context.Products.Any())
        {
            return; // DB has been seeded
        }

        var products = new Product[]
        {
            new Product { Name = "Kenny's Special", Price = 99.99M },
            new Product { Name = "Hat", Price = 19.99M },
            new Product { Name = "Shirt", Price = 29.99M },
            new Product { Name = "Shoes", Price = 199.99M }
        };

        foreach (var p in products)
        {
            context.Products.Add(p);
        }

        context.SaveChanges();
    }
}
